﻿namespace presentacion
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboHelp = new System.Windows.Forms.ComboBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(93, 373);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(35, 13);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "Help?";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(189, 51);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // cboHelp
            // 
            this.cboHelp.FormattingEnabled = true;
            this.cboHelp.Location = new System.Drawing.Point(189, 369);
            this.cboHelp.Name = "cboHelp";
            this.cboHelp.Size = new System.Drawing.Size(43, 21);
            this.cboHelp.TabIndex = 5;
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(189, 141);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(357, 208);
            this.txtHelp.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(189, 99);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.cboHelp);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboHelp;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}