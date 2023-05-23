using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class WorkSpace : UserControl
    {
        public WorkSpace(Size size)
        {
            InitializeComponent();
            Anchor = AnchorStyles.None;
            BackColor = Color.White;
            Size = size;
        }

        public bool draw = false;
        public List<Figure> array = new List<Figure>();
        public Graphics g;
        private Point point1;
        private Point point2;

        private void WorkSpace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                g = CreateGraphics();
                point1 = new Point(e.X, e.Y);
                point2 = new Point(e.X, e.Y);
                ((Form2)ParentForm).rectangle = new MyRectangle(point1, point2,
                    lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                    fillColor: ((Form1)ParentForm.ParentForm).paramFillColor,
                    dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                    thickness: ((Form1)ParentForm.ParentForm).paramThickness,
                    isFill: ((Form1)ParentForm.ParentForm).paramIsFill);
            }
        }

        private void WorkSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                ((Form2)ParentForm).rectangle.Hide(g);
                point2 = new Point(e.X, e.Y);
                if (point2.X > 0 && point2.X < Size.Width &&
                    point2.Y > 0 && point2.Y < Size.Height)
                {
                    ((Form2)ParentForm).rectangle = new MyRectangle(point1, point2,
                        lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                        fillColor: ((Form1)ParentForm.ParentForm).paramFillColor,
                        dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                        thickness: ((Form1)ParentForm.ParentForm).paramThickness,
                        isFill: ((Form1)ParentForm.ParentForm).paramIsFill);
                }
                else if (!(point2.X > 0 && point2.X < Size.Width) ||
                         !(point2.Y > 0 && point2.Y < Size.Height))
                {
                    ((Form2)ParentForm).rectangle = new MyRectangle(point1, point2,
                        lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                        fillColor: ((Form1)ParentForm.ParentForm).paramFillColor,
                        dashColor: Color.Red,
                        thickness: ((Form1)ParentForm.ParentForm).paramThickness,
                        isFill: ((Form1)ParentForm.ParentForm).paramIsFill); ;
                }
                ((Form2)ParentForm).rectangle.DrawDash(g);
            }
        }

        private void WorkSpace_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in array)
            {
                f.Draw(e.Graphics);
            }
        }

        private void WorkSpace_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw && e.Button == MouseButtons.Left)
            {
                if (((Form2)ParentForm).rectangle.inBorder(Size))
                {
                    ((Form2)ParentForm).rectangle.Draw(g);
                    array.Add(((Form2)ParentForm).rectangle);

                    if (!((Form2)ParentForm).save)
                    {
                        if (((Form2)ParentForm).open)
                        {
                            ((Form1)ParentForm.ParentForm).сохранитьToolStripMenuItem.Enabled = true;
                        }
                        ((Form2)ParentForm).save = true;
                    }
                }
                else
                {
                    ((Form2)ParentForm).rectangle.Hide(g);
                }

            }
            draw = false;
            Invalidate();
        }

        private void WorkSpace_MouseEnter(object sender, EventArgs e)
        {

        }

        private void WorkSpace_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
