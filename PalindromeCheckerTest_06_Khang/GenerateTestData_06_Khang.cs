using System;
using System.IO;
using ClosedXML.Excel;

namespace PalindromeCheckerTest_06_Khang
{
    public class GenerateTestData_06_Khang
    {
        public static void CreateExcelFile()
        {
            string projectDirectory_06_Khang = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string folderPath_06_Khang = Path.Combine(projectDirectory_06_Khang, "TestData_06_Khang");

            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(folderPath_06_Khang))
            {
                Directory.CreateDirectory(folderPath_06_Khang);
            }

            string filePath_06_Khang = Path.Combine(folderPath_06_Khang, "TestData_06_Khang.xlsx");

            using (var workbook_06_Khang = new XLWorkbook())
            {
                var worksheet_06_Khang = workbook_06_Khang.Worksheets.Add("TestData_06_Khang");

                // Ghi tiêu đề
                worksheet_06_Khang.Cell(1, 1).Value = "Input_06_Khang";
                worksheet_06_Khang.Cell(1, 2).Value = "ExpectedOutput_06_Khang";

                // Ghi dữ liệu test vào từng dòng
                string[,] testData_06_Khang = {
                    { "66x66", "True" },
                    { "abc", "False" },
                    { "ma d   a m", "True" },
                    { "aa   bb 2 d", "True" }
                };

                for (int i_06_Khang = 0; i < testData_06_Khang.GetLength(0); i_06_Khang++)
                {
                    worksheet_06_Khang.Cell(i_06_Khang + 2, 1).Value = testData_06_Khang[i_06_Khang, 0];
                    worksheet_06_Khang.Cell(i_06_Khang + 2, 2).Value = testData_06_Khang[i_06_Khang, 1];
                }

                // Lưu file
                workbook_06_Khang.SaveAs(filePath_06_Khang);
                Console.WriteLine($"File {filePath_06_Khang} đã được tạo thành công!");
            }
        }
    }
}
