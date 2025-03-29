using System;
using System.Collections.Generic;
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
        public void ValidPalindrome_06_Khang_1()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang("madam"));
            
        }

        [TestMethod]//Test case 2, chuoi: abc khong la 1 chuoi palindrome => tra ra False, nhung ket qua mong doi lai tra ra True => Failed
        public void ValidPalindrome_06_Khang_2()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang("abc"));

        }

        [TestMethod]//Test case 3, chuoi: ma d   a m la 1 chuoi palindrome mac du co khoang trang => tra ra true => Passed
        public void PalindromeWithSpaces_06_Khang_1()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang("ma d   a m "));
        }

        [TestMethod]//Test case 4, chuoi: " aa   bb 2 d " khong la 1 chuoi palindrome mac du co khoang trang => tra ra False, nhung ket qua mong doi la True => Failed
        public void PalindromeWithoutWord_06_Khang_2()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang(" aa   bb 2 d "));
        }

        [TestMethod]//Test case 5, chuoi la null => tra ra False => Passed
        public void PalindromeWithNull_06_Khang_1()
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang(null));
        }

        [TestMethod]//Test case 6, chuoi la "aba" khac null => tra ra True => Failed 
        public void PalindromeWithNull_06_Khang_2()
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang("aba"));
        }

       
    }
}
