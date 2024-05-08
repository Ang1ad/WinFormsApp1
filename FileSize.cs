using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FileSize : Form
    {
        public Size size;

        public FileSize()
        {
            InitializeComponent();
            setSize(320, 240);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = !panel2.Enabled;
            panel1.Enabled = !panel1.Enabled;

            if (checkBox1.Checked)
            {
                if (textBox1.Text.Length > 0) size.Width = Convert.ToInt32(textBox1.Text);
                else size.Width = 0;
                if (textBox2.Text.Length > 0) size.Height = Convert.ToInt32(textBox2.Text);
                else size.Height = 0;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    setSize(320, 240);
                }
                else if (radioButton2.Checked)
                {
                    setSize(640, 480);
                }
                else if (radioButton3.Checked)
                {
                    setSize(800, 600);
                }
            }

            Text = size.Width.ToString() + "x" + size.Height.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck(textBox1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck(textBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setSize(320, 240);
            Text = size.Height.ToString() + 'x' + size.Width.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setSize(640, 480);
            Text = size.Height.ToString() + 'x' + size.Width.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            setSize(800, 600);
            Text = size.Height.ToString() + 'x' + size.Width.ToString();
        }

        public void setSize(int width, int height)
        {
            size.Height = height;
            size.Width = width;
        }

        private void textBoxCheck(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                if (textBox == textBox1) size.Width = Convert.ToInt32(textBox.Text);
                else if (textBox == textBox2) size.Height = Convert.ToInt32(textBox.Text);
                string str = textBox.Text;
                if (str[0] == '0')
                {
                    textBox.Text = "";
                }
            }
            else
            {
                if (textBox == textBox1) size.Width = 0;
                else if (textBox == textBox2) size.Height = 0;
            }

            Text = size.Width.ToString() + "x" + size.Height.ToString();
        }

        private void validCharacters(KeyPressEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text.Length == 0)
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
                {
                    return;
                }
            }
            else
            {
                if (((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '\b')) && (textBox.Text.Length < 4))
                {
                    return;
                }
                else if ((textBox.Text.Length == 4) && (e.KeyChar == '\b'))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validCharacters(e, textBox2);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validCharacters(e, textBox1);
        }
    }
}
