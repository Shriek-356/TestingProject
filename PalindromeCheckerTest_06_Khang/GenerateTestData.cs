using System;
using System.IO;
using ClosedXML.Excel;

namespace PalindromeCheckerTest_06_Khang
{
    public class GenerateTestData
    {
        public static void CreateExcelFile()
        {
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string folderPath = Path.Combine(projectDirectory, "TestData");

            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "TestData.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("TestData_06_Khang");

                // Ghi tiêu đề
                worksheet.Cell(1, 1).Value = "Input";
                worksheet.Cell(1, 2).Value = "ExpectedOutput";

                // Ghi dữ liệu test vào từng dòng
                string[,] testData = {
                    { "66x66", "True" },
                    { "abc", "False" },
                    { "ma d   a m", "True" },
                    { "aa   bb 2 d", "True" },
                    { "null", "False" },
                    { "aba", "False" }
                };

                for (int i = 0; i < testData.GetLength(0); i++)
                {
                    worksheet.Cell(i + 2, 1).Value = testData[i, 0];
                    worksheet.Cell(i + 2, 2).Value = testData[i, 1];
                }

                // Lưu file
                workbook.SaveAs(filePath);
                Console.WriteLine($"File {filePath} đã được tạo thành công!");
            }
        }
    }
}
