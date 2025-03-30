using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;

namespace PalindromeCheckerTest_06_Khang
{
    public class ExcelDataReader
    {
        public static IEnumerable<object[]> ReadTestData_06_Khang(string filePath)
        {
            var testData = new List<object[]>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Không tìm thấy file: {filePath}");
            }

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // Lấy sheet đầu tiên
                var rows = worksheet.RangeUsed().RowsUsed(); // Lấy tất cả các dòng có dữ liệu

                foreach (var row in rows.Skip(1)) // Bỏ qua dòng tiêu đề
                {
                    string input = row.Cell(1).GetString();
                    bool expectedOutput = bool.Parse(row.Cell(2).GetString());
                    testData.Add(new object[] { input, expectedOutput });
                }
            }

            return testData;
        }
    }
}
