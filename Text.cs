using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable()]
    public class Text : Figure
    {
        public Text(Point point1, Point point2, Color lineColor, Color dashColor, int thickness, Font font, Form parent) :
            base(point1, point2, lineColor, dashColor, thickness, font)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.lineColor = lineColor;
            this.dashColor = dashColor;
            this.thickness = thickness;
            this.font = font;
            this.parent = parent;
        }

        private Font font;
        private string text = System.String.Empty;
        [NonSerialized()]
        private Form parent;

        public override void Draw(Graphics g)
        {

            Rectangle rectangle = Rectangle.FromLTRB(Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Max(point1.X, point2.X), Math.Max(point1.Y, point2.Y));
            SolidBrush brush = new SolidBrush(lineColor);
            /*TextBox textBox = new TextBox();
            textBox.Font = font;
            textBox.Width = Math.Abs(point1.X - point2.X);
            textBox.Height = Math.Abs(point1.Y - point2.Y);
            textBox.BorderStyle = BorderStyle.None;
            textBox.Show();*/
            ToolStripLabel label = new ToolStripLabel();
            TextDialog textDialog = new TextDialog();
            DialogResult result = textDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                label.Text = textDialog.textBox1.Text;
            }
            label.Width = Math.Abs(point1.X - point2.X);
            label.Height = Math.Abs(point1.Y - point2.Y);
            Pen pen = new Pen(lineColor, thickness);
            g.DrawString(text, font, brush, rectangle);
            g.DrawRectangle(pen, rectangle);
        }

        public override void DrawDash(Graphics g)
        {
            Pen pen = new Pen(dashColor, thickness);
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
        public void Click(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                parent.Invalidate();
                text = textBox.Text;
                textBox.Dispose();
                Form1 f = (Form1)parent.ParentForm;
                f.drawFontType(font, true);
            }
        }
    }
}
