﻿namespace YaziliOrtalamaHesapla
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Yazılı";
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(91, 48);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(130, 26);
            this.txtYazili1.TabIndex = 1;
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(91, 80);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(130, 26);
            this.txtYazili2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Yazılı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(251, 48);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(168, 58);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 175);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
    }
}

