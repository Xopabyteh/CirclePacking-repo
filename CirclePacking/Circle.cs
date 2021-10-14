using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CirclePacking
{
    public class Circle
    {
        private readonly Color _circleColor;
        public Point Position { get; set; }
        public int Radius { get; set; }
        public float Thickness { get; set; }

        public Circle(Point position, float thickness, Color circleColor)
        {
            _circleColor = circleColor;
            Position = position;
            Thickness = thickness;
            Radius = 1;
        }


       

        public void DrawSelf(ref Graphics g)
        {
            Pen pen = new Pen(_circleColor, Thickness);
            //Brush brush = new SolidBrush(_circleColor);
            g.ResetTransform();
            g.TranslateTransform(-Radius, -Radius);
            g.DrawEllipse(pen,Position.X,Position.Y,Radius*2,Radius*2);
            //g.FillEllipse(brush,Position.X,Position.Y,Radius*2,Radius*2);
        }
    }
}