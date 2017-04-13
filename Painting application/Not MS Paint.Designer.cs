namespace Painting_application
{
    partial class Not_MS_Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZOOM = new System.Windows.Forms.Button();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberLines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnZOOM);
            this.panel1.Controls.Add(this.lblActual);
            this.panel1.Controls.Add(this.btnGO);
            this.panel1.Controls.Add(this.txtIncrement);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Controls.Add(this.txtAngle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumberLines);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnZOOM
            // 
            this.btnZOOM.Location = new System.Drawing.Point(415, 9);
            this.btnZOOM.Name = "btnZOOM";
            this.btnZOOM.Size = new System.Drawing.Size(48, 23);
            this.btnZOOM.TabIndex = 10;
            this.btnZOOM.Text = "ZOOM";
            this.btnZOOM.UseVisualStyleBackColor = true;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActual.Location = new System.Drawing.Point(469, 14);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(10, 13);
            this.lblActual.TabIndex = 9;
            this.lblActual.Text = "-";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(378, 9);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(34, 23);
            this.btnGO.TabIndex = 8;
            this.btnGO.Text = "GO!";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(335, 11);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(37, 20);
            this.txtIncrement.TabIndex = 7;
            this.txtIncrement.Text = "1";
            this.txtIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(232, 11);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(37, 20);
            this.txtLength.TabIndex = 6;
            this.txtLength.Text = "50";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(143, 11);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(37, 20);
            this.txtAngle.TabIndex = 5;
            this.txtAngle.Text = "90";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(275, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Increment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(186, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle";
            // 
            // txtNumberLines
            // 
            this.txtNumberLines.Location = new System.Drawing.Point(60, 11);
            this.txtNumberLines.Name = "txtNumberLines";
            this.txtNumberLines.Size = new System.Drawing.Size(37, 20);
            this.txtNumberLines.TabIndex = 0;
            this.txtNumberLines.Text = "1";
            this.txtNumberLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Lines";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Info;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 42);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(488, 390);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Not_MS_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 432);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Not_MS_Paint";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painting Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Button btnZOOM;
    }
}

