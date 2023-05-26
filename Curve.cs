using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable()]
    public class Curve : Figure
    {
        public Curve (Point point1, Point point2, Color lineColor, Color dashColor, int thickness) :
            base (point1, point2, lineColor, dashColor, thickness) 
        {
            points.Add(point1);
            points.Add(point2);
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, thickness);
            g.DrawCurve(pen, points.ToArray());
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new Pen(dashColor, thickness);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            points.Add(new Point(point2.X, point2.Y));
            g.DrawCurve(pen, points.ToArray<Point>());
        }

        public override void Hide(Graphics g)
        {
            /*Pen pen = new Pen(Color.White, thickness);
            g.DrawCurve(pen, points.ToArray());*/
        }

        public override bool inBorder(Size size)
        {
            if (
                points[0].X >= 0 && points[0].X <= size.Width &&
                points[0].Y >= 0 && points[0].Y <= size.Height &&
                points[points.Count - 1].X >= 0 && points[points.Count - 1].X <= size.Width &&
                points[points.Count - 1].Y >= 0 && points[points.Count - 1].Y <= size.Height
                ) return true;
            return false;
        }
    }
}
