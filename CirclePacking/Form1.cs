using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace CirclePacking
{
    public partial class Form1 : Form
    {
        private int _width;
        private int _height;

        private readonly List<Circle> _circles = new List<Circle>();
        private readonly Dictionary<Point,Color> _possiblePositions = new Dictionary<Point,Color>();
        private int maxCircles ; 
        private int maxAttempts; 
        private int maxRadius; 
        private int minRadius;
        private int thickness; 

        private Bitmap referenceBitmap;
        public Form1()
        {
            InitializeComponent();
            pic_main.AllowDrop = true;
        }

        private void AssignVariables()
        {
            int.TryParse(tx_Ammount.Text, out maxCircles);
            int.TryParse(tx_Attempts.Text, out maxAttempts);
            int.TryParse(tx_MaxRadius.Text, out maxRadius);
            int.TryParse(tx_MinRadius.Text, out minRadius);
            int.TryParse(tx_Thickness.Text, out thickness);
        }
        private void SetupBitmap(string filePath)
        {
            Image referenceImg = Image.FromFile(filePath);
            referenceBitmap = new Bitmap(referenceImg);

            pic_main.Width = referenceImg.Width;
            pic_main.Height = referenceImg.Height;

            _width = pic_main.Width;
            _height = pic_main.Height;
        }
        private void CalcPossiblePositions()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    Color pixel = referenceBitmap.GetPixel(x, y);
                    if (pixel.A > 0)
                    {
                        _possiblePositions.Add(new Point(x,y),pixel);
                    }
                }
            }
        } 

        private void CreateAndAssignCircles()
        {
            _possiblePositions.Clear();
            CalcPossiblePositions();
            _circles.Clear();

            Bitmap bitmap = new Bitmap(_width, _height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.DarkSlateGray);

            int attempt = 0;
            while (_circles.Count < maxCircles)
            {
                if (_possiblePositions.Count < 1)
                {
                    break;
                }
                if (!GenerateCircle())
                {
                    attempt++;
                    if (attempt == maxAttempts)
                    {
                        break;
                    }
                }
                else
                {
                    attempt = 0;
                }
            }

            //Draw
            foreach (Circle circle in _circles)
            {
                circle.DrawSelf(ref g);
            }
            pic_main.Image = bitmap;
        }
        private bool GenerateCircle()
        {
            Circle circle = NewCircle();
            if (circle != null)
            {
                while (circle.Radius < maxRadius)
                {
                    if (TouchingEdge(circle))
                    {
                        break;
                    }

                    bool scale = true;
                    foreach (Circle otherCircle in _circles)
                    {
                        if (TouchingCircle(circle, otherCircle))
                        {
                            scale = false;
                            break;
                        }
                    }

                    if (!scale)
                    {
                        break;
                    }

                    circle.Radius++;
                }

                if (circle.Radius > minRadius)
                {
                    _circles.Add(circle);
                    return true;
                }
            }

            return false;
        }

        private Circle NewCircle()
        {
            Random rng = new Random();
            int randomIndex = rng.Next(0, _possiblePositions.Count);
            Point pos = _possiblePositions.Keys.ToArray()[randomIndex];
            Color color = _possiblePositions.Values.ToArray()[randomIndex];
            _possiblePositions.Remove(pos); //So we dont check it multiple times

            foreach (Circle circle in _circles)
            {
                if (dist(pos, circle.Position) < circle.Radius)
                {
                    return null;
                }
            }
            return new Circle(pos, thickness,color);
        }

        private bool TouchingEdge(Circle c) => (
            c.Position.X - c.Radius < c.Thickness || c.Position.X + c.Radius > _width - c.Thickness ||
            c.Position.Y - c.Radius < c.Thickness || c.Position.Y + c.Radius > _height - c.Thickness);

        private bool TouchingCircle(Circle circle, Circle other) =>
            (dist(circle.Position, other.Position) < circle.Radius + other.Radius + circle.Thickness);

        private float dist(Point a, Point b)
        {
            float c = MathF.Sqrt(MathF.Pow(b.X - a.X, 2)+ MathF.Pow(b.Y - a.Y, 2));
            return c;
        }

        private void pic_main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pic_main_DragDrop(object sender, DragEventArgs e)
        {
            string file = ((string[]) e.Data.GetData(DataFormats.FileDrop))[0];
            string[] _split = file.Split('.');
            string fileFormat = _split[_split.Length - 1];
            if (fileFormat == "png" || fileFormat == "jpg")
            {
                SetupBitmap(file);
                AssignVariables();
                CreateAndAssignCircles();
            }
        }
    }
}
