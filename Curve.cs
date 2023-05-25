using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Curve : Figure
    {
        public Curve (Point[] points, Color lineColor, Color dashColor, int thickness) :
            base (points, lineColor, dashColor, thickness) { }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawCurve(pen, points);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new Pen(dashColor, thickness);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawCurve(pen, points);
        }

        public override void Hide(Graphics g)
        {
            Pen pen = new Pen(Color.White, thickness);
            g.DrawCurve(pen, points);
        }

        public override bool inBorder(Size size)
        {
            if (
                points[0].X >= 0 && points[0].X <= size.Width &&
                points[0].Y >= 0 && points[0].Y <= size.Height &&
                points[points.Length].X >= 0 && points[points.Length].X <= size.Width &&
                points[points.Length].Y >= 0 && points[points.Length].Y <= size.Height
                ) return true;
            return false;
        }
    }
}
