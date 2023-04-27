namespace presentacion
{
    partial class frmDetalle
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.chkHelp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(93, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(93, 103);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(93, 145);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(41, 13);
            this.lblWords.TabIndex = 2;
            this.lblWords.Text = "Words:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(189, 51);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtWords
            // 
            this.txtWords.Enabled = false;
            this.txtWords.Location = new System.Drawing.Point(189, 141);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(357, 208);
            this.txtWords.TabIndex = 6;
            // 
            // numScore
            // 
            this.numScore.Enabled = false;
            this.numScore.Location = new System.Drawing.Point(189, 103);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(43, 20);
            this.numScore.TabIndex = 7;
            // 
            // chkHelp
            // 
            this.chkHelp.AutoSize = true;
            this.chkHelp.Location = new System.Drawing.Point(96, 389);
            this.chkHelp.Name = "chkHelp";
            this.chkHelp.Size = new System.Drawing.Size(54, 17);
            this.chkHelp.TabIndex = 8;
            this.chkHelp.Text = "Help?";
            this.chkHelp.UseVisualStyleBackColor = true;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkHelp);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFecha);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.CheckBox chkHelp;
    }
}