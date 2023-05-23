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
        public bool draw = false;
        public bool save = false;
        public bool open = false;
        public List<Figure> array = new List<Figure>();
        private Graphics g;
        private MyRectangle rectangle;
        private Point point1;
        private Point point2;

        public Form2(Size size)
        {
            InitializeComponent();

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                g = CreateGraphics();
                point1 = new Point(e.X, e.Y);
                point2 = new Point(e.X, e.Y);



                rectangle = new MyRectangle(point1, point2,
                    lineColor: ((Form1)ParentForm).paramLineColor,
                    fillColor: ((Form1)ParentForm).paramFillColor,
                    thickness: ((Form1)ParentForm).paramThickness,
                    isFill:    ((Form1)ParentForm).paramIsFill);
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                rectangle.Hide(g);
                point2 = new Point(e.X, e.Y);
                rectangle = new MyRectangle(point1, point2,
                    lineColor: ((Form1)ParentForm).paramLineColor,
                    fillColor: ((Form1)ParentForm).paramFillColor,
                    thickness: ((Form1)ParentForm).paramThickness,
                    isFill:    ((Form1)ParentForm).paramIsFill);
                rectangle.DrawDash(g);
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in array)
            {
                f.Draw(e.Graphics);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw && e.Button == MouseButtons.Left)
            {
                rectangle = new MyRectangle(point1, point2,
                    lineColor: ((Form1)ParentForm).paramLineColor,
                    fillColor: ((Form1)ParentForm).paramFillColor, 
                    thickness: ((Form1)ParentForm).paramThickness, 
                    isFill:    ((Form1)ParentForm).paramIsFill);
                rectangle.Draw(g);
                array.Add(rectangle);
                Invalidate();

                if (!save)
                {
                    if (open) ((Form1)ParentForm).сохранитьToolStripMenuItem.Enabled = true;
                    save = true;
                }
            }
            draw = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            if (save)
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    if (open) ((Form1)ParentForm).Save(this);
                    else e.Cancel = ((Form1)ParentForm).SaveAs(this);
                }
                else if (dr == DialogResult.Cancel) e.Cancel = true;
            }
            if (((Form1)ParentForm).MdiChildren.Length == 1 && !e.Cancel)
            {
                ((Form1)ParentForm).сохранитьToolStripMenuItem.Enabled = false;
                ((Form1)ParentForm).сохранитьКакToolStripMenuItem.Enabled = false;
            }
        }

        private void FormActivate(object sender, EventArgs e)
        {
            ((Form1)ParentForm).сохранитьToolStripMenuItem.Enabled = open && save;
            ((Form1)ParentForm).сохранитьКакToolStripMenuItem.Enabled = true;
        }
    }
}