using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color baseLineColor = Color.Black;
        public Color baseFillColor = Color.White;
        public int baseThickness = 1;


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

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThicknessDialog thicknessDialog = new ThicknessDialog();
            DialogResult result = thicknessDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void цветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor(ref baseLineColor);
        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor(ref baseFillColor);
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
    }
}