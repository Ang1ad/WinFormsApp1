namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            окноToolStripMenuItem = new ToolStripMenuItem();
            параметрыToolStripMenuItem = new ToolStripMenuItem();
            цветЛинииToolStripMenuItem = new ToolStripMenuItem();
            цветЗаливкиToolStripMenuItem = new ToolStripMenuItem();
            толщинаЛинииToolStripMenuItem = new ToolStripMenuItem();
            режимЗаливкиToolStripMenuItem = new ToolStripMenuItem();
            вклToolStripMenuItem = new ToolStripMenuItem();
            выклToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, окноToolStripMenuItem, параметрыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = окноToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(50, 21);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            новыйToolStripMenuItem.Size = new Size(177, 24);
            новыйToolStripMenuItem.Text = "Новый";
            новыйToolStripMenuItem.Click += НовыйToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(177, 24);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += ОткрытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(177, 24);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += СохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(177, 24);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem.Click += СохранитьКакToolStripMenuItem_Click;
            // 
            // окноToolStripMenuItem
            // 
            окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            окноToolStripMenuItem.Size = new Size(51, 21);
            окноToolStripMenuItem.Text = "Окно";
            окноToolStripMenuItem.Click += ОкноToolStripMenuItem_Click;
            // 
            // параметрыToolStripMenuItem
            // 
            параметрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветЛинииToolStripMenuItem, цветЗаливкиToolStripMenuItem, толщинаЛинииToolStripMenuItem, режимЗаливкиToolStripMenuItem });
            параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            параметрыToolStripMenuItem.Size = new Size(89, 21);
            параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // цветЛинииToolStripMenuItem
            // 
            цветЛинииToolStripMenuItem.Name = "цветЛинииToolStripMenuItem";
            цветЛинииToolStripMenuItem.Size = new Size(198, 24);
            цветЛинииToolStripMenuItem.Text = "Цвет линии";
            цветЛинииToolStripMenuItem.Click += ЦветЛинииToolStripMenuItem_Click;
            // 
            // цветЗаливкиToolStripMenuItem
            // 
            цветЗаливкиToolStripMenuItem.Name = "цветЗаливкиToolStripMenuItem";
            цветЗаливкиToolStripMenuItem.Size = new Size(198, 24);
            цветЗаливкиToolStripMenuItem.Text = "Цвет заливки";
            цветЗаливкиToolStripMenuItem.Click += ЦветЗаливкиToolStripMenuItem_Click;
            // 
            // толщинаЛинииToolStripMenuItem
            // 
            толщинаЛинииToolStripMenuItem.Name = "толщинаЛинииToolStripMenuItem";
            толщинаЛинииToolStripMenuItem.Size = new Size(198, 24);
            толщинаЛинииToolStripMenuItem.Text = "Толщина линии";
            толщинаЛинииToolStripMenuItem.Click += ТолщинаЛинииToolStripMenuItem_Click;
            // 
            // режимЗаливкиToolStripMenuItem
            // 
            режимЗаливкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вклToolStripMenuItem, выклToolStripMenuItem });
            режимЗаливкиToolStripMenuItem.Name = "режимЗаливкиToolStripMenuItem";
            режимЗаливкиToolStripMenuItem.Size = new Size(198, 24);
            режимЗаливкиToolStripMenuItem.Text = "Режим заливки";
            // 
            // вклToolStripMenuItem
            // 
            вклToolStripMenuItem.Name = "вклToolStripMenuItem";
            вклToolStripMenuItem.Size = new Size(198, 24);
            вклToolStripMenuItem.Text = "Вкл.";
            вклToolStripMenuItem.Click += ВклToolStripMenuItem_Click;
            // 
            // выклToolStripMenuItem
            // 
            выклToolStripMenuItem.Checked = true;
            выклToolStripMenuItem.CheckState = CheckState.Checked;
            выклToolStripMenuItem.Name = "выклToolStripMenuItem";
            выклToolStripMenuItem.Size = new Size(198, 24);
            выклToolStripMenuItem.Text = "Выкл.";
            выклToolStripMenuItem.Click += ВыклToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1008, 727);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem окноToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новыйToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        public ToolStripMenuItem сохранитьToolStripMenuItem;
        public ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem цветЛинииToolStripMenuItem;
        private ToolStripMenuItem цветЗаливкиToolStripMenuItem;
        private ToolStripMenuItem толщинаЛинииToolStripMenuItem;
        private ToolStripMenuItem режимЗаливкиToolStripMenuItem;
        public ToolStripMenuItem вклToolStripMenuItem;
        public ToolStripMenuItem выклToolStripMenuItem;
    }
}