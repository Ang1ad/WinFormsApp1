using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        int x1, y1, x2, y2;
        bool draw = false;
        Graphics g;
        List<Figure> array = new List<Figure>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x1 = e.X;
                y1 = e.Y;
                draw = true;
                
                g = CreateGraphics();
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (draw == true)
                {
                    x2 = e.X; y2 = e.Y;
                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    MyRectangle rectangle = new MyRectangle(point1, point2);
                    rectangle.DrawDash(g); 
                    MyRectangle rectangle1 = new MyRectangle(point1, point2);
                    rectangle1.Hide(g);
                }
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in array)
            {
                f.Draw(g);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {
                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);
                MyRectangle rectangle1 = new MyRectangle(point1, point2);
                rectangle1.Hide(g);
                MyRectangle rect = new MyRectangle(point1, point2);
                rect.Draw(g);
                array.Add(rect);
                Invalidate();
            }
            draw = false;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}