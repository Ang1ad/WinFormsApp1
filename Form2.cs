﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form2(Size size)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            ClientSize = size;
            AutoScrollMinSize = size;
            workSpace = new WorkSpace(size);
            Controls.Clear();
            Controls.Add(workSpace);
        }


        public bool save = false;
        public bool open = false;

        public MyRectangle rectangle;
        public WorkSpace workSpace;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FormActivate(object sender, EventArgs e)
        {
            ((Form1)ParentForm).сохранитьToolStripMenuItem.Enabled = open && save;
            ((Form1)ParentForm).сохранитьКакToolStripMenuItem.Enabled = true;
            ((Form1)ParentForm).ChangeDocSizeValue(this);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save)
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?", ((Form1)ParentForm).ActiveMdiChild.Text.ToString(), MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    if (open) ((Form1)ParentForm).Save(this);
                    else e.Cancel = ((Form1)ParentForm).SaveAs(this);
                    workSpace.buffer.Dispose();
                    workSpace.bufferContext.Dispose();
                    workSpace.g.Dispose();
                }
                else if (dr == DialogResult.Cancel) e.Cancel = true;
            }
            if (((Form1)ParentForm).MdiChildren.Length == 1 && !e.Cancel)
            {
                ((Form1)ParentForm).сохранитьToolStripMenuItem.Enabled = false;
                ((Form1)ParentForm).сохранитьКакToolStripMenuItem.Enabled = false;
            }
        }
    }
}