using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace N1_06_Khang_WebDriver
{
    public class TestDangKy_06_Khang
    {

        private String emailValue_06_Khang;
        private String passwordValue_06_Khang;
        private String firstnameValue_06_Khang;
        private String lastnameValue_06_Khang;

        public TestDangKy_06_Khang(string emailValue_06_Khang, string passwordValue_06_Khang, string firstnameValue_06_Khang, string lastnameValue_06_Khang)
        {
            this.emailValue_06_Khang = emailValue_06_Khang;
            this.passwordValue_06_Khang = passwordValue_06_Khang;
            this.firstnameValue_06_Khang = firstnameValue_06_Khang;
            this.lastnameValue_06_Khang = lastnameValue_06_Khang;
        }

        public TestDangKy_06_Khang()
        {

        }

        public void ExecuteSignUp_06_Khang() {

            ChromeDriverService chrome_06_Khang = ChromeDriverService.CreateDefaultService();
            chrome_06_Khang.HideCommandPromptWindow = true;

            // Đảm bảo rằng ChromeDriver sử dụng dịch vụ đã cấu hình
            IWebDriver driver_06_Khang = new ChromeDriver(chrome_06_Khang);
            driver_06_Khang.Navigate().GoToUrl("https://profile.w3schools.com/signup?redirect_url=https%3A%2F%2Fwww.w3schools.com%2F");

            //Dung XPath voi PlaceHolder
            IWebElement email_06_Khang = driver_06_Khang.FindElement(By.XPath("//input[@placeholder='email']"));
            email_06_Khang.SendKeys(emailValue_06_Khang);

            //Dung CssSelector voi PlaceHolder
            IWebElement password_06_Khang = driver_06_Khang.FindElement(By.CssSelector("input[placeholder='password']"));
            password_06_Khang.SendKeys(passwordValue_06_Khang);

            //Dung CssSelector voi PlaceHolder
            IWebElement firstname_06_Khang = driver_06_Khang.FindElement(By.CssSelector("input[placeholder='first name']"));
            firstname_06_Khang.SendKeys(firstnameValue_06_Khang);

            //Dung CssSelector voi PlaceHolder
            IWebElement lastname_06_Khang = driver_06_Khang.FindElement(By.CssSelector("input[placeholder='last name']"));
            lastname_06_Khang.SendKeys(lastnameValue_06_Khang);

            //Dung XPath voi Text
            IWebElement signUpButton_06_Khang = driver_06_Khang.FindElement(By.XPath("//button[text()='Sign Up']"));
            signUpButton_06_Khang.Click();

        }

        public void TestCase1_InvalidEmail_06_Khang()
        {
            TestDangKy_06_Khang testCase1_06_Khang = new TestDangKy_06_Khang(
               "khang@gmail",
               "Khang@123",
               "Khang",
               "Duy"
               );
            testCase1_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase2_PasswordNotIncludeUpperCaseCharacter_06_Khang()
        {
            TestDangKy_06_Khang testCase2_06_Khang = new TestDangKy_06_Khang(
               "khang@gmail.com",
               "khang@123",
               "Khang",
               "Duy"
               );
            testCase2_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase3_PasswordNotIncludeLowercaseCharacter_06_Khang() {

            TestDangKy_06_Khang testCase3_06_Khang = new TestDangKy_06_Khang(
               "khang@gmail.com",
               "KHANG@123",
               "Khang",
               "Duy"
               );
            testCase3_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase4_PasswordNotIncludeNumber_06_Khang()
        {
            TestDangKy_06_Khang testCase4_06_Khang = new TestDangKy_06_Khang(
               "khang@gmail.com",
               "Khang@",
               "Khang",
               "Duy"
               );
            testCase4_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase5_PasswordNotIncludeSpecialCharacter_06_Khang()
        {
            TestDangKy_06_Khang testCase5_06_Khang = new TestDangKy_06_Khang(
               "khang@gmail.com",
               "Khang123",
               "Khang",
               "Duy"
               );
            testCase5_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase6_PasswordNotEnough8Characters_06_Khang()
        {
            TestDangKy_06_Khang testCase6_06_Khang = new TestDangKy_06_Khang(
               "khang@gmail.com",
               "Kh@123",
               "Khang",
               "Duy"
               );
            testCase6_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase7_FieldsNotFilled_06_Khang()
        {
            TestDangKy_06_Khang testCase7_06_Khang = new TestDangKy_06_Khang(
                "khang@gmail.com",
                "",
                "Khang",
                "Duy"
                );
            testCase7_06_Khang.ExecuteSignUp_06_Khang();
        }
        
        public void TestCase8_EmailExist_06_Khang()
        {
            TestDangKy_06_Khang testCase8_06_Khang = new TestDangKy_06_Khang(
                "khangvskiss@gmail.com",
                "Khang@123",
                "Khang",
                "Duy"
                );
            testCase8_06_Khang.ExecuteSignUp_06_Khang();
        }

        public void TestCase9_ValidInfo_06_Khang()
        {
            TestDangKy_06_Khang testCase8_06_Khang = new TestDangKy_06_Khang(
                "khang1@gmail.com",
                "Khang@123",
                "Khang",
                "Duy"
                );
            testCase8_06_Khang.ExecuteSignUp_06_Khang();
        }


    }
}
