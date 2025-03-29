using System;
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


        [TestMethod]
        public void ValidPalindrome_06_Khang_1()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang("madam"));
            
        }

        [TestMethod]
        public void ValidPalindrome_06_Khang_2()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang("asd"));

        }

        [TestMethod]
        public void PalindromeWithSpaces_06_Khang()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang("ma d   a m "));
        }

        [TestMethod]
        public void PalindromeWithoutWord_06_Khang()
        {
            Assert.IsFalse(checker_06_Khang.IsPalindrome_06_Khang("   "));
        }

        [TestMethod]
        public void PalindromeWithNull_06_Khang()
        {
            Assert.IsTrue(checker_06_Khang.IsPalindrome_06_Khang(null));
        }
    }
}
