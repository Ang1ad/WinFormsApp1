namespace WinFormsApp1
{
    partial class TextDialog
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
            OK = new Button();
            Cancel = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // OK
            // 
            OK.DialogResult = DialogResult.OK;
            OK.Location = new Point(39, 54);
            OK.Name = "OK";
            OK.Size = new Size(83, 25);
            OK.TabIndex = 0;
            OK.Text = "Принять";
            OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(261, 54);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(83, 25);
            Cancel.TabIndex = 1;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // TextDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 98);
            Controls.Add(textBox1);
            Controls.Add(Cancel);
            Controls.Add(OK);
            Name = "TextDialog";
            Text = "TextDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK;
        private Button Cancel;
        public TextBox textBox1;
    }
}