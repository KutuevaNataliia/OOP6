
using System.Drawing;

namespace OOP6
{
    partial class FormRectangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormRectangle";
        }

        #endregion

        System.Drawing.Graphics graphics;
        private int RecXL;
        private int RecYL;
        private int RecXR;
        private int RecYR;

        public void PaintRectangle(object sender, MyEvent myEvent)
        {
            graphics = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            myEvent.getCoordinates(myEvent.RectangleLeft, ref RecXL, ref RecYL);
            myEvent.getCoordinates(myEvent.RectangleRight, ref RecXR, ref RecYR);
            Rectangle rectangle = new Rectangle(RecXL, RecYL, RecXR, RecYR);
            graphics.DrawRectangle(blackPen, rectangle);
        }
    }
}