﻿namespace N1_06_Khang_WebDriver
{
    partial class Form1_06_Khang
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
            this.btn_06_Khang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_06_Khang
            // 
            this.btn_06_Khang.Location = new System.Drawing.Point(342, 201);
            this.btn_06_Khang.Name = "btn_06_Khang";
            this.btn_06_Khang.Size = new System.Drawing.Size(75, 23);
            this.btn_06_Khang.TabIndex = 0;
            this.btn_06_Khang.Text = "Browse";
            this.btn_06_Khang.UseVisualStyleBackColor = true;
            this.btn_06_Khang.Click += new System.EventHandler(this.btn_06_Khang_Click);
            // 
            // Form1_06_Khang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_06_Khang);
            this.Name = "Form1_06_Khang";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_06_Khang;
    }
}

