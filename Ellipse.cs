using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable()]
    public class Ellipse : MyRectangle
    {
        public Ellipse(Point point1, Point point2, Color lineColor, Color fillColor, Color dashColor, int thickness, bool isFill) :
            base(point1, point2, lineColor, fillColor, dashColor, thickness, isFill) { }

        public override void Draw(Graphics g)
        {
            Pen pen = new(lineColor, thickness);
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            if (isFill) 
            {
                SolidBrush brush = new(fillColor);
                g.FillEllipse(brush, rectangle);
            }
            g.DrawEllipse(pen, rectangle);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new(dashColor, thickness)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawEllipse(pen, rectangle);
        }

        public override void Hide(Graphics g)
        {
            Pen pen = new(Color.White, thickness);
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawEllipse (pen, rectangle);
        }

        public override bool InBorder(Size size)
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
