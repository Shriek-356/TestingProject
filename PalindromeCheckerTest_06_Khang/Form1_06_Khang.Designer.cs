namespace PalindromeCheckerTest_06_Khang
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_06_Khang = new System.Windows.Forms.TextBox();
            this.buttonKiemtra_06_Khang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Chuỗi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_06_Khang
            // 
            this.txt_06_Khang.Location = new System.Drawing.Point(254, 124);
            this.txt_06_Khang.Name = "txt_06_Khang";
            this.txt_06_Khang.Size = new System.Drawing.Size(100, 22);
            this.txt_06_Khang.TabIndex = 1;
            // 
            // buttonKiemtra_06_Khang
            // 
            this.buttonKiemtra_06_Khang.Location = new System.Drawing.Point(263, 198);
            this.buttonKiemtra_06_Khang.Name = "buttonKiemtra_06_Khang";
            this.buttonKiemtra_06_Khang.Size = new System.Drawing.Size(75, 23);
            this.buttonKiemtra_06_Khang.TabIndex = 2;
            this.buttonKiemtra_06_Khang.Text = "Kiểm tra";
            this.buttonKiemtra_06_Khang.UseVisualStyleBackColor = true;
            // 
            // Form1_06_Khang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 304);
            this.Controls.Add(this.buttonKiemtra_06_Khang);
            this.Controls.Add(this.txt_06_Khang);
            this.Controls.Add(this.label1);
            this.Name = "Form1_06_Khang";
            this.Text = "Form1_06_Khang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_06_Khang;
        private System.Windows.Forms.Button buttonKiemtra_06_Khang;
    }
}

