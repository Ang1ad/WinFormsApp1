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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            фигураToolStripMenuItem = new ToolStripMenuItem();
            прямоугольникToolStripMenuItem = new ToolStripMenuItem();
            эллипсToolStripMenuItem = new ToolStripMenuItem();
            прямаяToolStripMenuItem = new ToolStripMenuItem();
            криваяToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            PenSize = new ToolStripStatusLabel();
            PenSizeValue = new ToolStripStatusLabel();
            PenColor = new ToolStripStatusLabel();
            PenColorValue = new ToolStripStatusLabel();
            FillColor = new ToolStripStatusLabel();
            FillColorValue = new ToolStripStatusLabel();
            MouseCoords = new ToolStripStatusLabel();
            MouseCoordsValue = new ToolStripStatusLabel();
            DocSize = new ToolStripStatusLabel();
            DocSizeValue = new ToolStripStatusLabel();
            FontValue = new ToolStripStatusLabel();
            FontSize = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            NewFile = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SaveFile = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Thickness = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            LineColor = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            Fill = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            Size = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            Font = new ToolStripButton();
            StandardFont = new ToolStripButton();
            TextButton = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, окноToolStripMenuItem, параметрыToolStripMenuItem, фигураToolStripMenuItem });
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
            новыйToolStripMenuItem.Click += новыйToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(177, 24);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(177, 24);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(177, 24);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // окноToolStripMenuItem
            // 
            окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            окноToolStripMenuItem.Size = new Size(51, 21);
            окноToolStripMenuItem.Text = "Окно";
            окноToolStripMenuItem.Click += окноToolStripMenuItem_Click;
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
            цветЛинииToolStripMenuItem.Size = new Size(175, 24);
            цветЛинииToolStripMenuItem.Text = "Цвет линии";
            цветЛинииToolStripMenuItem.Click += цветЛинииToolStripMenuItem_Click;
            // 
            // цветЗаливкиToolStripMenuItem
            // 
            цветЗаливкиToolStripMenuItem.Name = "цветЗаливкиToolStripMenuItem";
            цветЗаливкиToolStripMenuItem.Size = new Size(175, 24);
            цветЗаливкиToolStripMenuItem.Text = "Цвет заливки";
            цветЗаливкиToolStripMenuItem.Click += цветЗаливкиToolStripMenuItem_Click;
            // 
            // толщинаЛинииToolStripMenuItem
            // 
            толщинаЛинииToolStripMenuItem.Name = "толщинаЛинииToolStripMenuItem";
            толщинаЛинииToolStripMenuItem.Size = new Size(175, 24);
            толщинаЛинииToolStripMenuItem.Text = "Толщина линии";
            толщинаЛинииToolStripMenuItem.Click += толщинаЛинииToolStripMenuItem_Click;
            // 
            // режимЗаливкиToolStripMenuItem
            // 
            режимЗаливкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вклToolStripMenuItem, выклToolStripMenuItem });
            режимЗаливкиToolStripMenuItem.Name = "режимЗаливкиToolStripMenuItem";
            режимЗаливкиToolStripMenuItem.Size = new Size(175, 24);
            режимЗаливкиToolStripMenuItem.Text = "Режим заливки";
            // 
            // вклToolStripMenuItem
            // 
            вклToolStripMenuItem.Name = "вклToolStripMenuItem";
            вклToolStripMenuItem.Size = new Size(114, 24);
            вклToolStripMenuItem.Text = "Вкл.";
            вклToolStripMenuItem.Click += вклToolStripMenuItem_Click;
            // 
            // выклToolStripMenuItem
            // 
            выклToolStripMenuItem.Checked = true;
            выклToolStripMenuItem.CheckState = CheckState.Checked;
            выклToolStripMenuItem.Name = "выклToolStripMenuItem";
            выклToolStripMenuItem.Size = new Size(114, 24);
            выклToolStripMenuItem.Text = "Выкл.";
            выклToolStripMenuItem.Click += выклToolStripMenuItem_Click;
            // 
            // фигураToolStripMenuItem
            // 
            фигураToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { прямоугольникToolStripMenuItem, эллипсToolStripMenuItem, прямаяToolStripMenuItem, криваяToolStripMenuItem });
            фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            фигураToolStripMenuItem.Size = new Size(62, 21);
            фигураToolStripMenuItem.Text = "Фигура";
            // 
            // прямоугольникToolStripMenuItem
            // 
            прямоугольникToolStripMenuItem.Checked = true;
            прямоугольникToolStripMenuItem.CheckState = CheckState.Checked;
            прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            прямоугольникToolStripMenuItem.Size = new Size(176, 24);
            прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            прямоугольникToolStripMenuItem.Click += прямоугольникToolStripMenuItem_Click;
            // 
            // эллипсToolStripMenuItem
            // 
            эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            эллипсToolStripMenuItem.Size = new Size(176, 24);
            эллипсToolStripMenuItem.Text = "Эллипс";
            эллипсToolStripMenuItem.Click += эллипсToolStripMenuItem_Click;
            // 
            // прямаяToolStripMenuItem
            // 
            прямаяToolStripMenuItem.Name = "прямаяToolStripMenuItem";
            прямаяToolStripMenuItem.Size = new Size(176, 24);
            прямаяToolStripMenuItem.Text = "Прямая";
            прямаяToolStripMenuItem.Click += прямаяToolStripMenuItem_Click;
            // 
            // криваяToolStripMenuItem
            // 
            криваяToolStripMenuItem.Name = "криваяToolStripMenuItem";
            криваяToolStripMenuItem.Size = new Size(176, 24);
            криваяToolStripMenuItem.Text = "Кривая";
            криваяToolStripMenuItem.Click += криваяToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.ImageScalingSize = new Size(18, 18);
            statusStrip1.Items.AddRange(new ToolStripItem[] { PenSize, PenSizeValue, PenColor, PenColorValue, FillColor, FillColorValue, MouseCoords, MouseCoordsValue, DocSize, DocSizeValue, FontValue, FontSize });
            statusStrip1.Location = new Point(0, 701);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.ShowItemToolTips = true;
            statusStrip1.Size = new Size(1008, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // PenSize
            // 
            PenSize.Name = "PenSize";
            PenSize.Size = new Size(88, 21);
            PenSize.Text = "Размер пера:";
            // 
            // PenSizeValue
            // 
            PenSizeValue.Name = "PenSizeValue";
            PenSizeValue.Size = new Size(47, 21);
            PenSizeValue.Text = " -- : -- ";
            PenSizeValue.Click += toolStripStatusLabel2_Click;
            // 
            // PenColor
            // 
            PenColor.Name = "PenColor";
            PenColor.Size = new Size(73, 21);
            PenColor.Text = "Цвет пера:";
            // 
            // PenColorValue
            // 
            PenColorValue.AutoSize = false;
            PenColorValue.BackColor = Color.White;
            PenColorValue.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            PenColorValue.BorderStyle = Border3DStyle.Etched;
            PenColorValue.Name = "PenColorValue";
            PenColorValue.Size = new Size(30, 21);
            // 
            // FillColor
            // 
            FillColor.Name = "FillColor";
            FillColor.Size = new Size(91, 21);
            FillColor.Text = "Цвет заливки:";
            // 
            // FillColorValue
            // 
            FillColorValue.AutoSize = false;
            FillColorValue.BackColor = Color.White;
            FillColorValue.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            FillColorValue.BorderStyle = Border3DStyle.Etched;
            FillColorValue.Name = "FillColorValue";
            FillColorValue.Size = new Size(30, 21);
            // 
            // MouseCoords
            // 
            MouseCoords.Name = "MouseCoords";
            MouseCoords.Size = new Size(138, 21);
            MouseCoords.Text = "Координаты курсора:";
            // 
            // MouseCoordsValue
            // 
            MouseCoordsValue.Name = "MouseCoordsValue";
            MouseCoordsValue.Size = new Size(47, 21);
            MouseCoordsValue.Text = " -- : -- ";
            // 
            // DocSize
            // 
            DocSize.Name = "DocSize";
            DocSize.Size = new Size(106, 21);
            DocSize.Text = "Размер рисунка:";
            // 
            // DocSizeValue
            // 
            DocSizeValue.Name = "DocSizeValue";
            DocSizeValue.Size = new Size(47, 21);
            DocSizeValue.Text = " -- : -- ";
            // 
            // FontValue
            // 
            FontValue.Name = "FontValue";
            FontValue.Size = new Size(109, 21);
            FontValue.Text = "TimesNewRoman";
            FontValue.Visible = false;
            // 
            // FontSize
            // 
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(0, 21);
            FontSize.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { NewFile, toolStripSeparator1, SaveFile, toolStripSeparator2, toolStripButton3, toolStripSeparator3, Thickness, toolStripSeparator4, LineColor, toolStripSeparator7, Fill, toolStripSeparator5, Size, toolStripSeparator6, toolStripButton7, toolStripButton8, toolStripButton9, toolStripButton10, toolStripSeparator8, Font, StandardFont, TextButton });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1008, 57);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // NewFile
            // 
            NewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewFile.Image = (Image)resources.GetObject("NewFile.Image");
            NewFile.ImageTransparentColor = Color.Magenta;
            NewFile.Name = "NewFile";
            NewFile.Size = new Size(54, 54);
            NewFile.Text = "toolStripButton1";
            NewFile.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 57);
            // 
            // SaveFile
            // 
            SaveFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveFile.Image = (Image)resources.GetObject("SaveFile.Image");
            SaveFile.ImageTransparentColor = Color.Magenta;
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(54, 54);
            SaveFile.Text = "toolStripButton2";
            SaveFile.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 57);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(54, 54);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 57);
            // 
            // Thickness
            // 
            Thickness.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Thickness.Image = (Image)resources.GetObject("Thickness.Image");
            Thickness.ImageTransparentColor = Color.Magenta;
            Thickness.Name = "Thickness";
            Thickness.Size = new Size(54, 54);
            Thickness.Text = "toolStripButton4";
            Thickness.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 57);
            // 
            // LineColor
            // 
            LineColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LineColor.Image = (Image)resources.GetObject("LineColor.Image");
            LineColor.ImageTransparentColor = Color.Magenta;
            LineColor.Name = "LineColor";
            LineColor.Size = new Size(54, 54);
            LineColor.Text = "toolStripButton5";
            LineColor.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 57);
            // 
            // Fill
            // 
            Fill.BackColor = Color.WhiteSmoke;
            Fill.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Fill.Image = (Image)resources.GetObject("Fill.Image");
            Fill.ImageTransparentColor = Color.Magenta;
            Fill.Name = "Fill";
            Fill.Size = new Size(54, 54);
            Fill.Text = "toolStripButton11";
            Fill.Click += toolStripButton11_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 57);
            // 
            // Size
            // 
            Size.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Size.Image = (Image)resources.GetObject("Size.Image");
            Size.ImageTransparentColor = Color.Magenta;
            Size.Name = "Size";
            Size.Size = new Size(54, 54);
            Size.Text = "toolStripButton6";
            Size.Click += toolStripButton6_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 57);
            // 
            // toolStripButton7
            // 
            toolStripButton7.Checked = true;
            toolStripButton7.CheckOnClick = true;
            toolStripButton7.CheckState = CheckState.Checked;
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(54, 54);
            toolStripButton7.Text = "toolStripButton7";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // toolStripButton8
            // 
            toolStripButton8.CheckOnClick = true;
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(54, 54);
            toolStripButton8.Text = "toolStripButton8";
            toolStripButton8.Click += toolStripButton8_Click;
            // 
            // toolStripButton9
            // 
            toolStripButton9.CheckOnClick = true;
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(54, 54);
            toolStripButton9.Text = "toolStripButton9";
            toolStripButton9.Click += toolStripButton9_Click;
            // 
            // toolStripButton10
            // 
            toolStripButton10.CheckOnClick = true;
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(54, 54);
            toolStripButton10.Text = "toolStripButton10";
            toolStripButton10.Click += toolStripButton10_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 57);
            // 
            // Font
            // 
            Font.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Font.Image = (Image)resources.GetObject("Font.Image");
            Font.ImageTransparentColor = Color.Magenta;
            Font.Name = "Font";
            Font.Size = new Size(54, 54);
            Font.Text = "toolStripButton12";
            Font.Click += Font_Click;
            // 
            // StandardFont
            // 
            StandardFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            StandardFont.Image = (Image)resources.GetObject("StandardFont.Image");
            StandardFont.ImageTransparentColor = Color.Magenta;
            StandardFont.Name = "StandardFont";
            StandardFont.Size = new Size(54, 54);
            StandardFont.Text = "toolStripButton13";
            // 
            // TextButton
            // 
            TextButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TextButton.Image = (Image)resources.GetObject("TextButton.Image");
            TextButton.ImageTransparentColor = Color.Magenta;
            TextButton.Name = "TextButton";
            TextButton.Size = new Size(54, 54);
            TextButton.Text = "toolStripButton14";
            TextButton.Click += TextButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 727);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        public SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem цветЛинииToolStripMenuItem;
        private ToolStripMenuItem цветЗаливкиToolStripMenuItem;
        private ToolStripMenuItem толщинаЛинииToolStripMenuItem;
        private ToolStripMenuItem режимЗаливкиToolStripMenuItem;
        public ToolStripMenuItem вклToolStripMenuItem;
        public ToolStripMenuItem выклToolStripMenuItem;
        private ToolStripMenuItem фигураToolStripMenuItem;
        public ToolStripMenuItem прямоугольникToolStripMenuItem;
        public ToolStripMenuItem эллипсToolStripMenuItem;
        public ToolStripMenuItem прямаяToolStripMenuItem;
        public ToolStripMenuItem криваяToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel PenSize;
        private ToolStripStatusLabel PenSizeValue;
        private ToolStripStatusLabel PenColor;
        private ToolStrip toolStrip1;
        private ToolStripButton NewFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton SaveFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Thickness;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton LineColor;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton Fill;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton Size;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        public ToolStripStatusLabel PenColorValue;
        public ToolStripStatusLabel FillColor;
        public ToolStripStatusLabel FillColorValue;
        private ToolStripStatusLabel MouseCoords;
        private ToolStripStatusLabel MouseCoordsValue;
        private ToolStripStatusLabel DocSize;
        private ToolStripStatusLabel DocSizeValue;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton Font;
        private ToolStripButton StandardFont;
        private ToolStripButton TextButton;
        private ToolStripStatusLabel FontValue;
        private ToolStripStatusLabel FontSize;
    }
}