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
            this.components = new System.ComponentModel.Container();
            this.panTopControl = new System.Windows.Forms.Panel();
            this.picbLineColour = new System.Windows.Forms.PictureBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.btnPaint = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.numIncrement = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblAngle = new System.Windows.Forms.Label();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.lblLinesNum = new System.Windows.Forms.Label();
            this.numLines = new System.Windows.Forms.NumericUpDown();
            this.panMain = new System.Windows.Forms.Panel();
            this.colourLines = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panCanvas = new System.Windows.Forms.Panel();
            this.panTopControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLineColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLines)).BeginInit();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTopControl
            // 
            this.panTopControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panTopControl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panTopControl.Controls.Add(this.picbLineColour);
            this.panTopControl.Controls.Add(this.lblColour);
            this.panTopControl.Controls.Add(this.btnPaint);
            this.panTopControl.Controls.Add(this.lblZoom);
            this.panTopControl.Controls.Add(this.numZoom);
            this.panTopControl.Controls.Add(this.lblIncrement);
            this.panTopControl.Controls.Add(this.numIncrement);
            this.panTopControl.Controls.Add(this.lblLength);
            this.panTopControl.Controls.Add(this.numLength);
            this.panTopControl.Controls.Add(this.lblAngle);
            this.panTopControl.Controls.Add(this.numAngle);
            this.panTopControl.Controls.Add(this.lblLinesNum);
            this.panTopControl.Controls.Add(this.numLines);
            this.panTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopControl.Location = new System.Drawing.Point(0, 0);
            this.panTopControl.Name = "panTopControl";
            this.panTopControl.Size = new System.Drawing.Size(784, 73);
            this.panTopControl.TabIndex = 0;
            // 
            // picbLineColour
            // 
            this.picbLineColour.BackColor = System.Drawing.Color.Red;
            this.picbLineColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbLineColour.Location = new System.Drawing.Point(295, 12);
            this.picbLineColour.Name = "picbLineColour";
            this.picbLineColour.Size = new System.Drawing.Size(47, 20);
            this.picbLineColour.TabIndex = 11;
            this.picbLineColour.TabStop = false;
            this.picbLineColour.Click += new System.EventHandler(this.picbLineColour_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.BackColor = System.Drawing.Color.Transparent;
            this.lblColour.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColour.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblColour.Location = new System.Drawing.Point(237, 12);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(52, 17);
            this.lblColour.TabIndex = 10;
            this.lblColour.Text = "Colour:";
            // 
            // btnPaint
            // 
            this.btnPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaint.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPaint.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnPaint.Location = new System.Drawing.Point(709, 36);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(63, 32);
            this.btnPaint.TabIndex = 9;
            this.btnPaint.Text = "Paint!";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.BackColor = System.Drawing.Color.Transparent;
            this.lblZoom.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZoom.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblZoom.Location = new System.Drawing.Point(242, 43);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(47, 17);
            this.lblZoom.TabIndex = 8;
            this.lblZoom.Text = "Zoom:";
            // 
            // numZoom
            // 
            this.numZoom.Location = new System.Drawing.Point(295, 43);
            this.numZoom.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(47, 20);
            this.numZoom.TabIndex = 7;
            this.numZoom.ThousandsSeparator = true;
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.BackColor = System.Drawing.Color.Transparent;
            this.lblIncrement.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncrement.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblIncrement.Location = new System.Drawing.Point(131, 43);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(47, 17);
            this.lblIncrement.TabIndex = 6;
            this.lblIncrement.Text = "Incre..:";
            // 
            // numIncrement
            // 
            this.numIncrement.Location = new System.Drawing.Point(182, 43);
            this.numIncrement.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numIncrement.Name = "numIncrement";
            this.numIncrement.Size = new System.Drawing.Size(47, 20);
            this.numIncrement.TabIndex = 5;
            this.numIncrement.ThousandsSeparator = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLength.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblLength.Location = new System.Drawing.Point(124, 12);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(54, 17);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length:";
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(182, 12);
            this.numLength.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(47, 20);
            this.numLength.TabIndex = 3;
            this.numLength.ThousandsSeparator = true;
            this.numLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblAngle.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAngle.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblAngle.Location = new System.Drawing.Point(20, 43);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(47, 17);
            this.lblAngle.TabIndex = 2;
            this.lblAngle.Text = "Angle:";
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(69, 43);
            this.numAngle.Maximum = new decimal(new int[] {
            1286608618,
            2,
            0,
            0});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(49, 20);
            this.numAngle.TabIndex = 1;
            this.numAngle.ThousandsSeparator = true;
            this.numAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lblLinesNum
            // 
            this.lblLinesNum.AutoSize = true;
            this.lblLinesNum.BackColor = System.Drawing.Color.Transparent;
            this.lblLinesNum.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLinesNum.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblLinesNum.Location = new System.Drawing.Point(20, 12);
            this.lblLinesNum.Name = "lblLinesNum";
            this.lblLinesNum.Size = new System.Drawing.Size(43, 17);
            this.lblLinesNum.TabIndex = 0;
            this.lblLinesNum.Text = "Lines:";
            this.toolTip.SetToolTip(this.lblLinesNum, "\r\n");
            // 
            // numLines
            // 
            this.numLines.Location = new System.Drawing.Point(69, 12);
            this.numLines.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numLines.Name = "numLines";
            this.numLines.Size = new System.Drawing.Size(49, 20);
            this.numLines.TabIndex = 0;
            this.numLines.ThousandsSeparator = true;
            this.numLines.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // panMain
            // 
            this.panMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panMain.BackColor = System.Drawing.SystemColors.Window;
            this.panMain.Controls.Add(this.panCanvas);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(784, 561);
            this.panMain.TabIndex = 1;
            // 
            // panCanvas
            // 
            this.panCanvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panCanvas.BackColor = System.Drawing.Color.White;
            this.panCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCanvas.Location = new System.Drawing.Point(0, 0);
            this.panCanvas.Name = "panCanvas";
            this.panCanvas.Size = new System.Drawing.Size(784, 561);
            this.panCanvas.TabIndex = 0;
            this.panCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panCanvas_Paint);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panTopControl);
            this.Controls.Add(this.panMain);
            this.Name = "Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.panTopControl.ResumeLayout(false);
            this.panTopControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLineColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLines)).EndInit();
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTopControl;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label lblLinesNum;
        private System.Windows.Forms.NumericUpDown numLines;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numIncrement;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.PictureBox picbLineColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.ColorDialog colourLines;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panCanvas;
    }
}