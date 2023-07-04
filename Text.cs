using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Text : Figure
    {
        public Text (Point point1, Point point2) : base (point1, point2)
        {

        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawRectangle(pen, rectangle);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new Pen(Color.Gray, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawRectangle(pen, rectangle);
        }

        public override void Hide(Graphics g)
        {
            Pen pen = new Pen(Color.White, 1);
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawRectangle(pen, rectangle);
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
