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
        public void TC1_ValidPalindrome_06_Khang(String input_06_Khang)
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }

        [TestMethod]//Test case 2, chuoi: ma d   a m la 1 chuoi palindrome mac du co khoang trang => tra ra true => Passed
        [DataRow("ma d   a m ")]
        public void TC2_PalindromeWithSpaces_06_Khang(String input_06_Khang)
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }

        [TestMethod]//Test case 3, chuoi la null => tra ra False => Passed
        [DataRow(null)]
        public void TC_3_PalindromeWithNull_06_Khang(String input_06_Khang)
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }

        [TestMethod]//Test case 4, chuoi khong phai la palindrome "notpalindrome" => tra ra false => Passed
        [DataRow("notpalindrome")]
        public void TC4_InvalidPalindrome_06_Khang(String input_06_Khang)
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }

        [TestMethod]//Test case 5, chuoi la khoang trang => tra ra false => Passed
        [DataRow("            ")]
        public void TC5_InvalidPalindrome_06_Khang(String input_06_Khang)
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang));
        }


        private static string filePath_06_Khang = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "..", "..", "..", "PalindromeCheckerTest_06_Khang", "TestData_06_Khang", "TestData_06_Khang.xlsx"
);

        //Doc file excel
        public static IEnumerable<object[]> TestCases_06_Khang()
        {
            try
            {
                Console.WriteLine($"Dang doc file tu duong dan: {filePath_06_Khang}");
                return PalindromeCheckerTest_06_Khang.ExcelDataReader_06_Khang.ReadTestData_06_Khang(filePath_06_Khang);
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Loi doc file: {ex.Message}");
                throw;
            }
        }

        [TestMethod]//Doc du lieu tu file excel de test
        [DynamicData(nameof(TestCases_06_Khang), DynamicDataSourceType.Method)]
        public void TestPalindromeWithExcel_06_Khang(string input_06_Khang, bool expected_06_Khang)
        {
            bool result_06_Khang = checker_06_Khang.IsPalindrome_06_Khang(input_06_Khang);
            Assert.AreEqual(expected_06_Khang, result_06_Khang, $"Failed for input: {input_06_Khang}");
        }

    }
}
