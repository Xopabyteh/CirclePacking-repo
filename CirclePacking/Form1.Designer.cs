
namespace CirclePacking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_main = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_Thickness = new System.Windows.Forms.TextBox();
            this.tx_MinRadius = new System.Windows.Forms.TextBox();
            this.tx_MaxRadius = new System.Windows.Forms.TextBox();
            this.tx_Attempts = new System.Windows.Forms.TextBox();
            this.tx_Ammount = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_main
            // 
            this.pic_main.Location = new System.Drawing.Point(0, 0);
            this.pic_main.Name = "pic_main";
            this.pic_main.Size = new System.Drawing.Size(827, 630);
            this.pic_main.TabIndex = 0;
            this.pic_main.TabStop = false;
            this.pic_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_main_DragDrop);
            this.pic_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_main_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 630);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tx_Thickness);
            this.panel2.Controls.Add(this.tx_MinRadius);
            this.panel2.Controls.Add(this.tx_MaxRadius);
            this.panel2.Controls.Add(this.tx_Attempts);
            this.panel2.Controls.Add(this.tx_Ammount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(627, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 630);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thickness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mi_Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ma_Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ma_Attempts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ammount";
            // 
            // tx_Thickness
            // 
            this.tx_Thickness.Location = new System.Drawing.Point(4, 129);
            this.tx_Thickness.Name = "tx_Thickness";
            this.tx_Thickness.Size = new System.Drawing.Size(100, 23);
            this.tx_Thickness.TabIndex = 4;
            this.tx_Thickness.Text = "1";
            // 
            // tx_MinRadius
            // 
            this.tx_MinRadius.Location = new System.Drawing.Point(4, 100);
            this.tx_MinRadius.Name = "tx_MinRadius";
            this.tx_MinRadius.Size = new System.Drawing.Size(100, 23);
            this.tx_MinRadius.TabIndex = 3;
            this.tx_MinRadius.Text = "3";
            // 
            // tx_MaxRadius
            // 
            this.tx_MaxRadius.Location = new System.Drawing.Point(4, 71);
            this.tx_MaxRadius.Name = "tx_MaxRadius";
            this.tx_MaxRadius.Size = new System.Drawing.Size(100, 23);
            this.tx_MaxRadius.TabIndex = 2;
            this.tx_MaxRadius.Text = "10";
            // 
            // tx_Attempts
            // 
            this.tx_Attempts.Location = new System.Drawing.Point(4, 42);
            this.tx_Attempts.Name = "tx_Attempts";
            this.tx_Attempts.Size = new System.Drawing.Size(100, 23);
            this.tx_Attempts.TabIndex = 1;
            this.tx_Attempts.Text = "200";
            // 
            // tx_Ammount
            // 
            this.tx_Ammount.Location = new System.Drawing.Point(4, 13);
            this.tx_Ammount.Name = "tx_Ammount";
            this.tx_Ammount.Size = new System.Drawing.Size(100, 23);
            this.tx_Ammount.TabIndex = 0;
            this.tx_Ammount.Text = "200";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(13, 593);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(175, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "Export to png";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Circle packing";
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tx_Ammount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_Thickness;
        private System.Windows.Forms.TextBox tx_MinRadius;
        private System.Windows.Forms.TextBox tx_MaxRadius;
        private System.Windows.Forms.TextBox tx_Attempts;
        private System.Windows.Forms.Button btn_export;
    }
}

