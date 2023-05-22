using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormsApp1
{
    [Serializable()]
    public abstract class Figure
    {
        public Point point1, point2;
        public Color lineColor, fillColor;
        public int thickness;
        public bool isFill;

        protected Figure(Point point1, Point point2, Color lineColor, Color fillColor, int thickness, bool isFill)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.thickness = thickness;
            this.isFill = isFill;
        }

        public abstract void Draw(Graphics g);

        public abstract void DrawDash(Graphics g);

        public abstract void Hide(Graphics g);
    }

}
