using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP6
{
    public partial class FormMain : Form1
    {
        public FormMain()
        {
            InitializeComponent();
        }


        public FormEllipse formEllipse = new FormEllipse();
        public FormRectangle formRectangle = new FormRectangle();
        public FormSubscribe formSubscribe;

        
        Timer timer = new Timer();
//        private bool eventPressedOnce = false;

        public delegate void DS(object sender, MyEvent e);
        public DS myDelegate;

        private void button2_Click(object sender, EventArgs e)
        {
            MyEventHandler myEventHandler = new MyEventHandler(this);
            myEventHandler.CreateEvent();
            /*if (!eventPressedOnce)
            {
               eventPressedOnce = true;
            }
            else
            {
                
                eventPressedOnce = false;
            }  */ 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formEllipse.Show();
            formRectangle.Show();
            formSubscribe = new FormSubscribe(this);
            formSubscribe.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Hide();
            progressBar1.Maximum = 10;
            progressBar1.Show();
            timer.Enabled = true;
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);


        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 5)
            {
                progressBar1.Value++;
            }
            else
            {
                timer.Stop();
                MyEventHandler myEventHandler = new MyEventHandler(this);
                myEventHandler.CreateEvent();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Show();
            progressBar1.Hide();
        }

        /*public void getCoordinates(TextBox textbox, ref int x, ref int y)
        {
            String rawString = textbox.Text;
            String[] subs = rawString.Split(' ');
            try
            {
                x = Int32.Parse(subs[0]);
                y = Int32.Parse(subs[1]);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input");
            }
        }*/
    }

    public class MyEvent : EventArgs
    {
        public String EllipseLeft;
        public String EllipseRight;

        public String RectangleLeft;
        public String RectangleRight;

        public void getCoordinates(String str, ref int x, ref int y)
        {
            String[] subs = str.Split(' ');
            try
            {
                x = Int32.Parse(subs[0]);
                y = Int32.Parse(subs[1]);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input");
            }
        }

    }

    public class MyEventHandler
    {
        private FormMain formMain;
        private MyEvent toSubscribe;
        private Action<object, EventArgs> timer_Tick;

        public MyEventHandler(FormMain formMain)
        {
            this.formMain = formMain;
        }

        public void CreateEvent()
        {
            toSubscribe = new MyEvent();

            toSubscribe.EllipseLeft = formMain.TextBox1.Text;
            toSubscribe.EllipseRight = formMain.TextBox3.Text;
            toSubscribe.RectangleLeft = formMain.TextBox2.Text;
            toSubscribe.RectangleRight = formMain.TextBox4.Text;

            formMain.myDelegate += (s, e) =>
            {
                Graphics graphics = formMain.formEllipse.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 3);
                int ElXL = 0;
                int ElYL = 0;
                int ElXR = 0;
                int ElYR = 0;
                MyEvent mEv = (MyEvent)e;
                mEv.getCoordinates(mEv.EllipseLeft, ref ElXL, ref ElYL);
                mEv.getCoordinates(mEv.EllipseRight, ref ElXR, ref ElYR);
                Rectangle rectangle = new Rectangle(ElXL, ElYL, ElXR, ElYR);
                graphics.DrawEllipse(blackPen, rectangle);
            };
            formMain.myDelegate += formMain.formRectangle.PaintRectangle;
            formMain.myDelegate?.Invoke(formMain, toSubscribe);
        }

    }
}
