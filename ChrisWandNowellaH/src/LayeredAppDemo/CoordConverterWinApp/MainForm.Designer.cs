namespace CoordConverterWinApp
{
    partial class MainForm
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
            this.tbxDeg = new System.Windows.Forms.TextBox();
            this.cboQuadrent = new System.Windows.Forms.ComboBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.tbxSec = new System.Windows.Forms.TextBox();
            this.Deg = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.quadrent = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxDeg
            // 
            this.tbxDeg.Location = new System.Drawing.Point(233, 41);
            this.tbxDeg.Name = "tbxDeg";
            this.tbxDeg.Size = new System.Drawing.Size(121, 22);
            this.tbxDeg.TabIndex = 0;
            this.tbxDeg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboQuadrent
            // 
            this.cboQuadrent.FormattingEnabled = true;
            this.cboQuadrent.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "W"});
            this.cboQuadrent.Location = new System.Drawing.Point(233, 189);
            this.cboQuadrent.Name = "cboQuadrent";
            this.cboQuadrent.Size = new System.Drawing.Size(121, 24);
            this.cboQuadrent.TabIndex = 1;
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(233, 92);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(121, 22);
            this.tbxMin.TabIndex = 2;
            this.tbxMin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxSec
            // 
            this.tbxSec.Location = new System.Drawing.Point(233, 143);
            this.tbxSec.Name = "tbxSec";
            this.tbxSec.Size = new System.Drawing.Size(121, 22);
            this.tbxSec.TabIndex = 3;
            // 
            // Deg
            // 
            this.Deg.AutoSize = true;
            this.Deg.Location = new System.Drawing.Point(163, 46);
            this.Deg.Name = "Deg";
            this.Deg.Size = new System.Drawing.Size(34, 17);
            this.Deg.TabIndex = 4;
            this.Deg.Text = "Deg";
            this.Deg.Click += new System.EventHandler(this.label1_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(167, 92);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(30, 17);
            this.Min.TabIndex = 5;
            this.Min.Text = "Min";
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.Location = new System.Drawing.Point(165, 143);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(32, 17);
            this.Sec.TabIndex = 6;
            this.Sec.Text = "Sec";
            // 
            // quadrent
            // 
            this.quadrent.AutoSize = true;
            this.quadrent.Location = new System.Drawing.Point(129, 196);
            this.quadrent.Name = "quadrent";
            this.quadrent.Size = new System.Drawing.Size(68, 17);
            this.quadrent.TabIndex = 7;
            this.quadrent.Text = "Quadrent";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(142, 336);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(97, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(266, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(126, 281);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(71, 17);
            this.Answer.TabIndex = 11;
            this.Answer.Text = "Dec. Deg:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 409);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.quadrent);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Deg);
            this.Controls.Add(this.tbxSec);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.cboQuadrent);
            this.Controls.Add(this.tbxDeg);
            this.Name = "MainForm";
            this.Text = "DMS Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDeg;
        private System.Windows.Forms.ComboBox cboQuadrent;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.TextBox tbxSec;
        private System.Windows.Forms.Label Deg;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.Label quadrent;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Answer;
    }
}

