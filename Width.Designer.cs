namespace WinFormsApp1
{
    partial class Width
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            OK = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "5", "8", "10", "12", "15" });
            comboBox1.Location = new Point(43, 12);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // OK
            // 
            OK.Location = new Point(12, 103);
            OK.Name = "OK";
            OK.Size = new Size(94, 25);
            OK.TabIndex = 1;
            OK.Text = "Принять";
            OK.UseVisualStyleBackColor = true;
            OK.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(113, 103);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 25);
            Cancel.TabIndex = 2;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += button2_Click;
            // 
            // Width
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 140);
            ControlBox = false;
            Controls.Add(Cancel);
            Controls.Add(OK);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Width";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Толщина линии";
            ResumeLayout(false);
        }

        #endregion

        public ComboBox comboBox1;
        private Button OK;
        private Button Cancel;
    }
}