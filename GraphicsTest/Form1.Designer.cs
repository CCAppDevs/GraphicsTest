namespace GraphicsTest
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
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(815, 400);
            DoubleBuffered = true;
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Graphics";
            WindowState = FormWindowState.Maximized;
            Paint += DrawFrame;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion
    }
}
