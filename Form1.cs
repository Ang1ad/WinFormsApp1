using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangePenSizeValue();
            ChangeLabelColor(paramLineColor, ref PenColorValue);
            ChangeLabelColor(paramFillColor, ref FillColorValue);
        }

        public Color paramLineColor = Color.Black;
        public Color paramFillColor = Color.White;
        public Color paramDashColor = Color.Gray;
        public int paramThickness = 1;
        public bool paramIsFill = false;
        public Font font = new("Times New Roman", 12);

        public enum Figures
        {
            Rectangle,
            Ellipse,
            Line,
            Curve,
            Text
        }

        public Figures figureType;
        public Figure figure;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void НовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();

        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save((Form2)ActiveMdiChild);
        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs((Form2)ActiveMdiChild);
        }

        public void Save(Form2 f)
        {
            XmlSerializer xmlSerializer = new(typeof(Stream));
            Stream fileStream = new FileStream(ActiveMdiChild.Text, FileMode.Create, FileAccess.Write, FileShare.None);
            SaveData saveData = new(f.workSpace.Size, f.workSpace.array);
            xmlSerializer.Serialize(fileStream, saveData);
            f.open = true;
            f.save = false;
            fileStream.Close();
        }

        public bool SaveAs(Form2 f)
        {
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            bool result = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //XmlSerializer xmlSerializer = new(typeof(Stream));
                Stream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                SaveData saveData = new(f.workSpace.Size, f.workSpace.array);
                BinaryWriter binaryWriter = new(fileStream);
                binaryWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                //XmlWriter xmlWriter = new XmlTextWriter(fileStream, Encoding.Unicode);
                //xmlSerializer.Serialize(xmlWriter, saveData);
                f.open = true;
                f.save = false;
                f.Text = saveFileDialog1.FileName;
                fileStream.Close();
                result = false;
            }
            return result;
        }

        private void ТолщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThickness();
        }

        private void ЦветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ref paramLineColor, ref PenColorValue);
            PenColorValue.BackColor = paramLineColor;
        }

        private void ЦветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ref paramFillColor, ref FillColorValue);
            FillColorValue.BackColor = paramFillColor;
        }

        private static void ChangeColor(ref Color color, ref ToolStripStatusLabel label)
        {
            ColorDialog colorDialog = new()
            {
                Color = color
            };
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog.Color;
                ChangeLabelColor(color, ref label);
            }
        }

        private void ВыклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            выклToolStripMenuItem.Checked = true;
            вклToolStripMenuItem.Checked = false;
            paramIsFill = вклToolStripMenuItem.Checked;
        }

        private void ВклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            вклToolStripMenuItem.Checked = true;
            выклToolStripMenuItem.Checked = false;
            paramIsFill = вклToolStripMenuItem.Checked;
        }

        private void ПрямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseRectangle();
        }

        private void ЭллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseEllipse();
        }

        private void ПрямаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseLine();
        }

        private void КриваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseCurve();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            ChooseRectangle();
        }

        public void ChooseRectangle()
        {
            прямоугольникToolStripMenuItem.Checked = !прямоугольникToolStripMenuItem.Checked;
            криваяToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            EllipseStripButton.Checked = false;
            LineStripButton.Checked = false;
            CurveStripButton.Checked = false;
            TextButton.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = true;
            режимЗаливкиToolStripMenuItem.Enabled = true;
            figureType = Figures.Rectangle;
        }

        public void ChooseEllipse()
        {
            эллипсToolStripMenuItem.Checked = !эллипсToolStripMenuItem.Checked;
            прямоугольникToolStripMenuItem.Checked = false;
            криваяToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            RectangleStripButton.Checked = false;
            LineStripButton.Checked = false;
            CurveStripButton.Checked = false;
            TextButton.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = true;
            режимЗаливкиToolStripMenuItem.Enabled = true;
            figureType = Figures.Ellipse;
        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            ChooseEllipse();
        }

        private void ToolStripButton9_Click(object sender, EventArgs e)
        {
            ChooseLine();
        }

        public void ChooseLine()
        {
            прямаяToolStripMenuItem.Checked = !прямаяToolStripMenuItem.Checked;
            прямоугольникToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            криваяToolStripMenuItem.Checked = false;
            RectangleStripButton.Checked = false;
            EllipseStripButton.Checked = false;
            CurveStripButton.Checked = false;
            TextButton.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Checked = false;
            figureType = Figures.Line;
        }

        public void ChooseCurve()
        {
            криваяToolStripMenuItem.Checked = !криваяToolStripMenuItem.Checked;
            прямоугольникToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            RectangleStripButton.Checked = false;
            EllipseStripButton.Checked = false;
            LineStripButton.Checked = false;
            TextButton.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Checked = false;
            figureType = Figures.Curve;
        }

        private void ToolStripButton10_Click(object sender, EventArgs e) //кривая
        {
            ChooseCurve();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e) //размер окна
        {
            if (!(Size.Checked = true))
            {
                FileSize size = new();
                DialogResult result = size.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    _ = new Form2(size.size);
                }
                Size.Checked = !Size.Checked;
            }
            else
            {
                Size.Checked = !Size.Checked;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e) //создание файла
        {
            CreateFile();
        }

        public void CreateFile()
        {
            FileSize fileSize = new();
            DialogResult result = fileSize.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Form f = new Form2(fileSize.size)
                {
                    MdiParent = this,
                    Text = "Рисунок " + this.MdiChildren.Length.ToString()
                };
                if (!this.сохранитьКакToolStripMenuItem.Enabled)
                {
                    this.сохранитьКакToolStripMenuItem.Enabled = true;
                }
                fileSize.Close();
                f.Show();
                ChangeDocSizeValue((Form2)ActiveMdiChild);
            }
        }

        public void OpenFile()
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new(typeof(Stream));
                Stream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData? data = xmlSerializer.Deserialize(fileStream) as SaveData;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                Form f = new Form2(data.size);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                ((Form2)f).open = true;
                f.MdiParent = this;
                f.Text = openFileDialog1.FileName;
                ((Form2)f).workSpace.array = data.arrayOfFigures;
                f.Show();
                if (!this.сохранитьКакToolStripMenuItem.Enabled)
                {
                    this.сохранитьКакToolStripMenuItem.Enabled = true;
                }
                fileStream.Close();
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e) //открытие
        {
            OpenFile();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e) //толщина
        {
            ChangeThickness();
        }

        public void ChangeThickness()
        {
            ThicknessDialog thicknessDialog = new();
            thicknessDialog.comboBox1.Text = paramThickness.ToString();
            DialogResult result = thicknessDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                paramThickness = Convert.ToInt32(thicknessDialog.comboBox1.SelectedItem);
                thicknessDialog.comboBox1.Text = thicknessDialog.comboBox1.SelectedItem.ToString();
                thicknessDialog.Close();
                ChangePenSizeValue();
            }
            else if (result == DialogResult.Cancel)
            {
                thicknessDialog.Close();
            }
        }

        private void ToolStripButton5_Click(object sender, EventArgs e) // цвет линии
        {
            ChangeColor(ref paramLineColor, ref PenColorValue);
        }

        private void ToolStripButton11_Click(object sender, EventArgs e) // заливка
        {
            if (Fill.Checked)
            {
                выклToolStripMenuItem.Checked = true;
                вклToolStripMenuItem.Checked = !выклToolStripMenuItem.Checked;
                paramIsFill = вклToolStripMenuItem.Checked;
                Fill.Checked = false;
            }
            else
            {
                ChangeColor(ref paramFillColor, ref FillColorValue);
                Fill.Checked = !Fill.Checked;
                вклToolStripMenuItem.Checked = Fill.Checked;
                выклToolStripMenuItem.Checked = !вклToolStripMenuItem.Checked;
                paramIsFill = вклToolStripMenuItem.Checked;
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e) //сохранение
        {
            if (окноToolStripMenuItem.Enabled)
            {
                Save((Form2)ActiveMdiChild);
            }
            else
            {
                SaveAs((Form2)ActiveMdiChild);
            }
        }
        //Кнопка размера рисунка
        //Нижняя панель

        public static void ChangeLabelColor(Color color, ref ToolStripStatusLabel label)
        {
            Bitmap Bitmap = new(20, 30);
            Rectangle rectangle = new(0, 0, 30, 20);
            Graphics g = Graphics.FromImage(Bitmap);
            SolidBrush brush = new(color);
            g.FillRectangle(brush, rectangle);
            Pen pen = new(Color.Black, 1);
            g.DrawRectangle(pen, rectangle);
            label.BackgroundImage = Bitmap;
        }

        public void ChangePenSizeValue()
        {
            PenSizeValue.Text = " " + paramThickness.ToString() + " ";
        }

        public void ChangeDocSizeValue(Form2 f)
        {
            DocSizeValue.Text = "  " + f.workSpace.Width.ToString() + "x" + f.workSpace.Height.ToString() + "  ";
        }

        public void ChangeMouseCoordsValue(MouseEventArgs e)
        {
            MouseCoordsValue.Text = "  " + e.X.ToString() + " ; " + e.Y.ToString() + "  ";
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new();
            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                font = fontDialog.Font;
            }
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            ChooseText();
        }

        public void DrawFontType(Font f, bool delete = false)
        {
            if (!delete)
            {
                FontValue.Text = "Шрифт:" + f.Name;
                FontSize.Text = "  Размер шрифта:" + f.Size;
            }
            else
            {
                FontValue.Text = String.Empty;
                FontSize.Text = String.Empty;
            }
        }

        public void ChooseText()
        {
            TextButton.Checked = !TextButton.Checked;
            криваяToolStripMenuItem.Checked = false;
            прямоугольникToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            CurveStripButton.Checked = false;
            RectangleStripButton.Checked = false;
            EllipseStripButton.Checked = false;
            LineStripButton.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Checked = false;
            figureType = Figures.Text;
        }
    }
}