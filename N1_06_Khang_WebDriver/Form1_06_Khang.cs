using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_06_Khang_WebDriver
{
    public partial class Form1_06_Khang : Form
    {
        public Form1_06_Khang()
        {
            InitializeComponent();
        }

        private void btn_06_Khang_Click(object sender, EventArgs e)
        {
            TestDangKy_06_Khang testDangKy_06_Khang = new TestDangKy_06_Khang();
            testDangKy_06_Khang.TestCase9_ValidInfo_06_Khang();
        }
    }
}
