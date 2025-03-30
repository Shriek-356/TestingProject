using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCheckerTest_06_Khang;

namespace TestPalindrome_06_Khang
{
    [TestClass]
    public class UnitTest_06_Khang
    {

        private PalindromeChecker_06_Khang checker_06_Khang;

        [TestInitialize]
        public void SetUp_06_Khang()
        {
            checker_06_Khang = new PalindromeChecker_06_Khang();
            
        }


        [TestMethod]//Test case 1, chuoi: madam la 1 chuoi palindrome => tra ra True => Passed
        [DataRow("madam")]
        [DataRow("cca")]
        public void ValidPalindrome_06_Khang_1(String input_06_Khang)
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }
        
        [TestMethod]//Test case 2, chuoi: ma d   a m la 1 chuoi palindrome mac du co khoang trang => tra ra true => Passed
        [DataRow("ma d   a m ")]
        [DataRow(" aa   bb 2 d ")]
        public void PalindromeWithSpaces_06_Khang_1(String input_06_Khang)
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }

        [TestMethod]//Test case 5, chuoi la null => tra ra False => Passed
        [DataRow(null)]
        [DataRow("aba")]
        public void PalindromeWithNull_06_Khang_1(String input_06_Khang)
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }

        
        private static string filePath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "..", "..", "..", "PalindromeCheckerTest_06_Khang", "TestData", "TestData.xlsx"
);

        public static IEnumerable<object[]> TestCases_06_Khang()
        {
            try
            {
                Console.WriteLine($"📌 Đang đọc file từ: {filePath}");
                return PalindromeCheckerTest_06_Khang.ExcelDataReader.ReadTestData_06_Khang(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Lỗi khi đọc file Excel: {ex.Message}");
                throw;
            }
        }

        [TestMethod]
        [DynamicData(nameof(TestCases_06_Khang), DynamicDataSourceType.Method)]
        public void TestPalindromeWithExcel_06_Khang(string input_06_Khang, bool expected_06_Khang)
        {
            bool result_06_Khang = checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang);
            Assert.AreEqual(expected_06_Khang, result_06_Khang, $"Failed for input: {input_06_Khang}");
        }

    }
}
