using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Color baseFillColor = Color.White;
        public Color baseLineColor = Color.Black;
        public int baseLineWidth = 1;
        public bool baseIsFill = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void окноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.MdiParent = this;
            f.Text = "Рисунок " + this.MdiChildren.Length.ToString();
            f.Show();
            if (!this.сохранитьКакToolStripMenuItem.Enabled)
            {
                this.сохранитьКакToolStripMenuItem.Enabled = true;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Form f = new Form2();
                ((Form2)f).open = true;
                f.MdiParent = this;
                f.Text = openFileDialog1.FileName;
                ((Form2)f).array = (List<Figure>)bf.Deserialize(fileStream);
                f.Show();
                if (!this.сохранитьКакToolStripMenuItem.Enabled)
                {
                    this.сохранитьКакToolStripMenuItem.Enabled = true;
                }
                fileStream.Dispose();
            }

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
            bf.Serialize(fileStream, f.array);
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
                bf.Serialize(fileStream, f.array);
                f.open = true;
                f.save = false;
                f.Text = saveFileDialog1.FileName;
                fileStream.Close();
                result = false;
            }
            return result;
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChangeColor(ref Color color)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = color;
            cd.ShowDialog(this);
            if (cd.ShowDialog(this) == DialogResult.OK)
            {
                color = cd.Color;
            }
        }

        private void цветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ref baseLineColor);
        }

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form width = new Width();
            width.Text = "Толщина линии";
            width.MdiParent = this;
            width.Show();*/
            Width width = new Width();
            width.comboBox1.Text = baseLineWidth.ToString();
            DialogResult dr = width.ShowDialog(this);

            if (dr == DialogResult.OK) 
            {
                baseLineWidth = Convert.ToInt32(width.comboBox1.SelectedItem);
                width.comboBox1.Text = width.comboBox1.SelectedItem.ToString();
                width.Close();
            }
            else if (dr == DialogResult.Cancel) 
            {
                width.Close();
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ref baseFillColor);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}