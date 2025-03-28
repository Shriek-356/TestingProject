using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalindromeCheckerTest_06_Khang;

namespace PalindromeCheckerTest_06_Khang
{
    public partial class Form1_06_Khang : Form
    {
        public Form1_06_Khang()
        {
            InitializeComponent();
        }

        private void buttonKiemtra_06_Khang_Click(object sender, EventArgs e)
        {
            String text_06_Khang = txt_06_Khang.Text;

            PalindromeChecker_06_Khang palindromeChecker_06_Khang = new PalindromeChecker_06_Khang();
            if (palindromeChecker_06_Khang.IsPalindrome_06_Khang(text_06_Khang))
            {
                MessageBox.Show("Dung");
            }
            else
                MessageBox.Show("Sai");
            
        }
    }
}
