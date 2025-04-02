using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromeCheckerTest_06_Khang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Console.WriteLine("Đang tạo file Excel...");
            GenerateTestData_06_Khang.CreateExcelFile_06_Khang(); // Chạy trước khi mở form
            Console.WriteLine("Hoàn thành!");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1_06_Khang());
            
        }
    }
}
