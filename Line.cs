using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable()]
    public class Line : Figure
    {
        public Line(Point point1, Point point2, Color lineColor, Color dashColor, int thickness) :
               base(point1, point2, lineColor, dashColor, thickness)   { }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, thickness);
            g.DrawLine(pen, point1, point2); 
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new Pen(dashColor, thickness);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, point1, point2);
        }

        public override void Hide(Graphics g)
        {
            Pen pen = new Pen(Color.White, thickness);
            g.DrawLine (pen, point1, point2);
        }

        public override bool inBorder(Size size)
        {
            if (
                point1.X >= 0 && point1.X <= size.Width &&
                point1.Y >= 0 && point1.Y <= size.Height &&
                point2.X >= 0 && point2.X <= size.Width &&
                point2.Y >= 0 && point2.Y <= size.Height
                ) return true;
            return false;
        }
    }
}
