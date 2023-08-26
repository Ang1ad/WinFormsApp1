using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using System.Xml.Serialization;

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
        public int paramThickness = 1;
        public bool paramIsFill = false;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void НовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2
            {
                MdiParent = this,
                Text = "Рисунок " + this.MdiChildren.Length.ToString()
            };
            f.Show();
            if (!this.сохранитьКакToolStripMenuItem.Enabled)
            {
                this.сохранитьКакToolStripMenuItem.Enabled = true;
            }
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new();
                //XmlSerializer xmlSerializer = new(typeof(Stream));
                Stream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Form f = new Form2();
                ((Form2)f).open = true;
                f.MdiParent = this;
                f.Text = openFileDialog1.FileName;
                if (((Form2)f).array != null)
                {
                    ((Form2)f).array = formatter.Deserialize(fileStream) as List<Figure>;
                }
                f.Show();
                if (!this.сохранитьКакToolStripMenuItem.Enabled)
                {
                    this.сохранитьКакToolStripMenuItem.Enabled = true;
                }
                fileStream.Dispose();
            }

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
            Stream fileStream = new FileStream(ActiveMdiChild.Text, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new();
            //XmlSerializer xmlSerializer = new(typeof(Stream));
            formatter.Serialize(fileStream, f.array);
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
                BinaryFormatter formatter = new();
                //XmlSerializer xmlSerializer = new(typeof(Stream));
                Stream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(fileStream, f.array);
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
            ThicknessDialog thicknessDialog = new();
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

        private void ЦветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ref paramLineColor);
        }

        private void ЦветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ref paramFillColor);
        }

        private static void ChangeColor(ref Color color)
        {
            ColorDialog colorDialog = new()
            {
                Color = color
            };
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog.Color;
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
    }
}