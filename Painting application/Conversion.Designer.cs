namespace Painting_application
{
    partial class Conversion
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
            this.panTopControl = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTopControl
            // 
            this.panTopControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopControl.Location = new System.Drawing.Point(0, 0);
            this.panTopControl.Name = "panTopControl";
            this.panTopControl.Size = new System.Drawing.Size(784, 42);
            this.panTopControl.TabIndex = 0;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panTopControl);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(784, 561);
            this.panMain.TabIndex = 1;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panMain);
            this.Name = "Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTopControl;
        private System.Windows.Forms.Panel panMain;
    }
}