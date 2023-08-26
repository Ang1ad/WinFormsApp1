using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    [Serializable()]
    public abstract class Figure
    {
        public Point point1, point2;
        public Color lineColor;
        public Color fillColor;
        public Color dashColor;
        [XmlElement("Thickness")]
        public int thickness;
        [XmlElement("Is fill")]
        public bool isFill;
        [XmlElement("Points")]
        public List<Point> points = new();
        public Font font;

        protected Figure(Point point1, Point point2, Color lineColor, Color fillColor, Color dashColor, int thickness, bool isFill)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.dashColor = dashColor;
            this.thickness = thickness;
            this.isFill = isFill;
        }

        protected Figure(Point point1, Point point2, Color lineColor, Color dashColor, int thickness)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.lineColor = lineColor;
            this.dashColor = dashColor;
            this.thickness = thickness;
        }

        protected Figure(Point point1, Point point2, Color lineColor, Color dashColor, int thickness, Font font)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.lineColor = lineColor;
            this.dashColor = dashColor;
            this.thickness = thickness;
            this.font = font;
        }

        public abstract void Draw(Graphics g);

        public abstract void DrawDash(Graphics g);

        public abstract void Hide(Graphics g);

        public abstract bool InBorder(Size size);


    }

    
}
