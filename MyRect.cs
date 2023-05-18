using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormsApp1
{
    [Serializable()]
    public class MyRectangle : Figure
    {
        public MyRectangle(Point point1, Point point2, Color lineColor, Color fillColor, int thickness) : 
            base(point1, point2, lineColor, fillColor, thickness) { }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, thickness);
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawRectangle(pen, rectangle);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new Pen(Color.Gray, thickness);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawRectangle(pen, rectangle);
        }

        public override void Hide(Graphics g)
        {
            Pen pen = new Pen(Color.White, thickness);
            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            g.DrawRectangle(pen, rectangle);
        }
    }
}
