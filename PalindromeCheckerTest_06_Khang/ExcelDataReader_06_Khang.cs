using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;

namespace PalindromeCheckerTest_06_Khang
{
    public class ExcelDataReader_06_Khang
    {
        public static IEnumerable<object[]> ReadTestData_06_Khang(string filePath_06_Khang  )
        {
            var testData_06_Khang = new List<object[]>();

            if (!File.Exists(filePath_06_Khang))
            {
                throw new FileNotFoundException($"Không tìm thấy file: {filePath_06_Khang}");
            }

            using (var workbook_06_Khang = new XLWorkbook(filePath_06_Khang))
            {
                var worksheet_06_Khang = workbook_06_Khang.Worksheet(1); // Lấy sheet đầu tiên
                var rows_06_Khang= worksheet_06_Khang.RangeUsed().RowsUsed(); // Lấy tất cả các dòng có dữ liệu

                foreach (var row_06_Khang in rows_06_Khang.Skip(1)) // Bỏ qua dòng tiêu đề
                {
                    string input = row_06_Khang.Cell(1).GetString();
                    bool expectedOutput = bool.Parse(row_06_Khang.Cell(2).GetString());
                    testData_06_Khang.Add(new object[] { input, expectedOutput });
                }
            }

            return testData_06_Khang;
        }
    }
}
