using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace TestPalindrome_06_Khang
{
    public class ExcelReader
    {
        public static IEnumerable<object[]> ReadTestData()
        {
            string projectDir = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(projectDir, "TestData_06_Khang", "test_data.xlsx");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Không tìm thấy file Excel: {filePath}");
            }

            var testData = new List<object[]>();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Bỏ qua dòng tiêu đề
                {
                    string testString = worksheet.Cells[row, 1].Text;
                    bool expectedResult = bool.Parse(worksheet.Cells[row, 2].Text);

                    testData.Add(new object[] { testString, expectedResult });
                }
            }

            return testData;
        }
    }
}
