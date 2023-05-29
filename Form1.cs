using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public Color paramLineColor = Color.Black;
        public Color paramFillColor = Color.White;
        public Color paramDashColor = Color.Gray;
        public int paramThickness = 1;
        public bool paramIsFill = false;

        public int figureNumber = 1;
        public Figure figure;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void окноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save((Form2)ActiveMdiChild);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs((Form2)ActiveMdiChild);
        }

        public void Save(Form2 f)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream fileStream = new FileStream(ActiveMdiChild.Text, FileMode.Create, FileAccess.Write, FileShare.None);
            SaveData saveData = new SaveData(f.workSpace.Size, f.workSpace.array);
            bf.Serialize(fileStream, saveData);
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
                BinaryFormatter bf = new BinaryFormatter();
                Stream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                SaveData saveData = new SaveData(f.workSpace.Size, f.workSpace.array);
                bf.Serialize(fileStream, saveData);
                f.open = true;
                f.save = false;
                f.Text = saveFileDialog1.FileName;
                fileStream.Close();
                result = false;
            }
            return result;
        }

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThickness();
        }

        private void цветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor(ref paramLineColor);
        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor(ref paramFillColor);
        }

        private void changeColor(ref Color color)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color;
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void выклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            выклToolStripMenuItem.Checked = true;
            вклToolStripMenuItem.Checked = false;
            paramIsFill = вклToolStripMenuItem.Checked;
        }

        private void вклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            вклToolStripMenuItem.Checked = true;
            выклToolStripMenuItem.Checked = false;
            paramIsFill = вклToolStripMenuItem.Checked;
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseRectangle();
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseEllipse();
        }

        private void прямаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseLine();
        }

        private void криваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseCurve();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        //StatusStrip statusBar = new StatusStrip();
        //Graphics graphicsStatusBar;

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ChooseRectangle();
        }

        public void ChooseRectangle()
        {
            прямоугольникToolStripMenuItem.Checked = !прямоугольникToolStripMenuItem.Checked;
            криваяToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            toolStripButton8.Checked = false;
            toolStripButton9.Checked = false;
            toolStripButton10.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = true;
            режимЗаливкиToolStripMenuItem.Enabled = true;
            figureNumber = 1;
        }

        public void ChooseEllipse()
        {
            эллипсToolStripMenuItem.Checked = !эллипсToolStripMenuItem.Checked;
            прямоугольникToolStripMenuItem.Checked = false;
            криваяToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            toolStripButton7.Checked = false;
            toolStripButton9.Checked = false;
            toolStripButton10.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = true;
            режимЗаливкиToolStripMenuItem.Enabled = true;
            figureNumber = 2;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ChooseEllipse();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            ChooseLine();
        }

        public void ChooseLine()
        {
            прямаяToolStripMenuItem.Checked = !прямаяToolStripMenuItem.Checked;
            прямоугольникToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            криваяToolStripMenuItem.Checked = false;
            toolStripButton7.Checked = false;
            toolStripButton8.Checked = false;
            toolStripButton10.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Checked = false;
            figureNumber = 3;
        }

        public void ChooseCurve()
        {
            криваяToolStripMenuItem.Checked = !криваяToolStripMenuItem.Checked;
            прямоугольникToolStripMenuItem.Checked = false;
            эллипсToolStripMenuItem.Checked = false;
            прямаяToolStripMenuItem.Checked = false;
            toolStripButton7.Checked = false;
            toolStripButton8.Checked = false;
            toolStripButton9.Checked = false;
            цветЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Enabled = false;
            режимЗаливкиToolStripMenuItem.Checked = false;
            figureNumber = 4;
        }

        private void toolStripButton10_Click(object sender, EventArgs e) //кривая
        {
            ChooseCurve();
        }

        private void toolStripButton6_Click(object sender, EventArgs e) //размер окна
        {
            if (toolStripButton6.Checked = true)
            {
                toolStripButton6.Checked = !toolStripButton6.Checked;
            }
            else
            {
                FileSize size = new FileSize();
                DialogResult result = size.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    Form f = new Form2(size.size);
                }
                toolStripButton6.Checked = !toolStripButton6.Checked;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //создание файла
        {
            CreateFile();
        }

        public void CreateFile()
        {
            FileSize fileSize = new FileSize();
            DialogResult result = fileSize.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Form f = new Form2(fileSize.size);
                f.MdiParent = this;
                f.Text = "Рисунок " + this.MdiChildren.Length.ToString();
                if (!this.сохранитьКакToolStripMenuItem.Enabled)
                {
                    this.сохранитьКакToolStripMenuItem.Enabled = true;
                }
                fileSize.Close();
                f.Show();
            }
        }

        public void OpenFile()
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData data = (SaveData)bf.Deserialize(fileStream);
                Form f = new Form2(data.size);
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

        private void toolStripButton3_Click(object sender, EventArgs e) //открытие
        {
            OpenFile();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //толщина
        {
            ChangeThickness();
        }

        public void ChangeThickness()
        {
            ThicknessDialog thicknessDialog = new ThicknessDialog();
            thicknessDialog.comboBox1.Text = paramThickness.ToString();
            DialogResult result = thicknessDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                paramThickness = Convert.ToInt32(thicknessDialog.comboBox1.SelectedItem);
                thicknessDialog.comboBox1.Text = thicknessDialog.comboBox1.SelectedItem.ToString();
                thicknessDialog.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                thicknessDialog.Close();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // цвет линии
        {
            changeColor(ref paramLineColor);
        }

        private void toolStripButton11_Click(object sender, EventArgs e) // заливка
        {
            if (toolStripButton11.Checked)
            {
                выклToolStripMenuItem.Checked = true;
                вклToolStripMenuItem.Checked = !выклToolStripMenuItem.Checked;
                paramIsFill = вклToolStripMenuItem.Checked;
                toolStripButton11.Checked = false;
            }
            else
            {
                changeColor(ref paramFillColor);
                toolStripButton11.Checked = !toolStripButton11.Checked;
                вклToolStripMenuItem.Checked = toolStripButton11.Checked;
                выклToolStripMenuItem.Checked = !вклToolStripMenuItem.Checked;
                paramIsFill = вклToolStripMenuItem.Checked;
            }


        }

        private void toolStripButton2_Click(object sender, EventArgs e) //сохранение
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


    }
}