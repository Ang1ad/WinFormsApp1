using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

        public Graphics g;
        public BufferedGraphics buffer;
        public BufferedGraphicsContext bufferContext;

        public bool draw = false;
        public List<Figure> array = new();
        private Point point1;
        private Point point2;

        private void WorkSpace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                point1 = new Point(e.X, e.Y);
                point2 = new Point(e.X, e.Y);
                if (((Form1)ParentForm.ParentForm).figureType == Form1.Figures.Rectangle)
                {
                    ((Form1)ParentForm.ParentForm).figure = new MyRectangle(point1, point2,
                    lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                    fillColor: ((Form1)ParentForm.ParentForm).paramFillColor,
                    dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                    thickness: ((Form1)ParentForm.ParentForm).paramThickness,
                    isFill: ((Form1)ParentForm.ParentForm).paramIsFill);
                }
                else if (((Form1)ParentForm.ParentForm).figureType == Form1.Figures.Ellipse)
                {
                    ((Form1)ParentForm.ParentForm).figure = new Ellipse(point1, point2,
                    lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                    fillColor: ((Form1)ParentForm.ParentForm).paramFillColor,
                    dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                    thickness: ((Form1)ParentForm.ParentForm).paramThickness,
                    isFill: ((Form1)ParentForm.ParentForm).paramIsFill);
                }    
                else if (((Form1)ParentForm.ParentForm).figureType == Form1.Figures.Line)
                {
                    ((Form1)ParentForm.ParentForm).figure = new Line(point1, point2,
                    lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                    dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                    thickness: ((Form1)ParentForm.ParentForm).paramThickness);
                }     
                else if (((Form1)ParentForm.ParentForm).figureType == Form1.Figures.Curve)
                {
                    ((Form1)ParentForm.ParentForm).figure = new Curve(point1, point2,
                    lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                    dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                    thickness: ((Form1)ParentForm.ParentForm).paramThickness);
                }      
                else if (((Form1)ParentForm.ParentForm).figureType == Form1.Figures.Text)
                {
                    ((Form1)ParentForm.ParentForm).figure = new Text(point1, point2,
                    lineColor: ((Form1)ParentForm.ParentForm).paramLineColor,
                    dashColor: ((Form1)ParentForm.ParentForm).paramDashColor,
                    thickness: ((Form1)ParentForm.ParentForm).paramThickness,
                    font: ((Form1)ParentForm.ParentForm).font,
                    parent: (Form1)ParentForm.ParentForm.Parent);
                }       
            }
        }

        private void WorkSpace_MouseMove(object sender, MouseEventArgs e)
        {
            ((Form1)ParentForm.ParentForm).ChangeMouseCoordsValue(e);
            if (draw)
            {
                buffer.Render(g);
                buffer.Graphics.FillRectangle(new SolidBrush(Color.White), DisplayRectangle);
                foreach (Figure f in array)
                {
                    f.Draw(buffer.Graphics);
                }
                point2 = new Point(e.X, e.Y);
                if ((point2.X > 0 && point2.X < Size.Width) ||
                    (point2.Y > 0 && point2.Y < Size.Height))
                {
                    ((Form1)ParentForm.ParentForm).figure.dashColor = ((Form1)ParentForm.ParentForm).paramDashColor;
                    ((Form1)ParentForm.ParentForm).figure.point2 = new Point(e.X, e.Y);
                }
                if (!(point2.X > 0 && point2.X < Size.Width) ||
                    !(point2.Y > 0 && point2.Y < Size.Height))
                {
                    ((Form1)ParentForm.ParentForm).figure.dashColor = Color.Red;
                    ((Form1)ParentForm.ParentForm).figure.point2 = new Point(e.X, e.Y);
                }
                ((Form1)ParentForm.ParentForm).figure.DrawDash(buffer.Graphics);
            }
        }

        private void WorkSpace_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in array)
            {
                if (((Form1)ParentForm.ParentForm).figureType != Form1.Figures.Text)
                f.Draw(e.Graphics);
            }
            buffer.Render(e.Graphics);
        }

        private void WorkSpace_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw && e.Button == MouseButtons.Left)
            {
                if (((Form1)ParentForm.ParentForm).figure.InBorder(Size))
                {
                    buffer.Render(g);
                    ((Form1)ParentForm.ParentForm).figure.Draw(buffer.Graphics);
                    array.Add(((Form1)ParentForm.ParentForm).figure);
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
                    buffer.Render(g);
                }
                draw = false;
                Invalidate();
            }
        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {
            bufferContext = BufferedGraphicsManager.Current;
            bufferContext.MaximumBuffer = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            g = CreateGraphics();
            Rectangle display = new(0, 0, Size.Width, Size.Height);
            buffer = bufferContext.Allocate(g, display);
        }
    }
}
