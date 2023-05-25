namespace WinFormsApp1
{
    partial class WorkSpace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // WorkSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
            Name = "WorkSpace";
            Load += WorkSpace_Load;
            Paint += WorkSpace_Paint;
            MouseDown += WorkSpace_MouseDown;
            MouseMove += WorkSpace_MouseMove;
            MouseUp += WorkSpace_MouseUp;
            ResumeLayout(false);
        }

        #endregion
    }
}
