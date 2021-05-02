using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP6
{
    public partial class FormSubscribe : Form1
    {
        FormMain formMain;
        public FormSubscribe(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            formMain.myDelegate += (s, ev) =>
            {
                MyEvent myEvent = (MyEvent) ev;
                TextBox1.Text = myEvent.EllipseLeft;
                TextBox3.Text = myEvent.EllipseRight;
                TextBox2.Text = myEvent.RectangleLeft;
                TextBox4.Text = myEvent.RectangleRight;
            };
        }
    }
}
