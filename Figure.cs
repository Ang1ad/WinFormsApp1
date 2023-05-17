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
        public Color lineColor;
        public Color fillColor;
        public float width;
        public bool isFill;

        protected Figure(Point point1, Point point2, Color lineColor, Color fillColor, float width, bool isFill)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.width = width;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.isFill = isFill;
        }

        public abstract void Draw(Graphics g);

        public abstract void DrawDash(Graphics g);

        public abstract void Hide(Graphics g);
    }

}
