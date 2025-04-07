using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V132.Network;

namespace N1_06_Khang_WebDriver
{
    public class TestDangNhap_06_Khang
    {
        private String emailValue_06_Khang;
        private String passwordValue_06_Khang;
        
        public TestDangNhap_06_Khang(String emailValue_06_Khang, String passwordValue_06_Khang)
        {
            this.emailValue_06_Khang=emailValue_06_Khang; 
            this.passwordValue_06_Khang= passwordValue_06_Khang;
        }

        public TestDangNhap_06_Khang()
        {

        }

        public void ExecuteLogin_06_Khang()
        {
            ChromeDriverService chrome_06_Khang = ChromeDriverService.CreateDefaultService();
            chrome_06_Khang.HideCommandPromptWindow = true;

            // Đảm bảo rằng ChromeDriver sử dụng dịch vụ đã cấu hình
            IWebDriver driver_06_Khang = new ChromeDriver(chrome_06_Khang);
            driver_06_Khang.Navigate().GoToUrl("https://profile.w3schools.com/login?redirect_url=https%3A%2F%2Fwww.w3schools.com%2F");

            //Dung truong name
            IWebElement email_06_Khang = driver_06_Khang.FindElement(By.Name("email"));
            email_06_Khang.SendKeys(emailValue_06_Khang);

            //CssSelector lay truong password = type
            IWebElement password_06_Khang = driver_06_Khang.FindElement(By.CssSelector("[type='password']"));
            password_06_Khang.SendKeys(passwordValue_06_Khang);

            //Dung XPath voi Text
            IWebElement signInButton_06_Khang = driver_06_Khang.FindElement(By.XPath("//button[text()='Login']"));
            signInButton_06_Khang.Click();
        }

        public void TestCase1_FieldsNotFilled_06_Khang()
        {
            TestDangNhap_06_Khang testDangNhap_06_Khang = new TestDangNhap_06_Khang(
                "khangvskiss@gmail.com",
                ""
                );

            testDangNhap_06_Khang.ExecuteLogin_06_Khang();
        }

        public void TestCase2_IncorrectPasswordOrEmail_06_Khang()
        {
            TestDangNhap_06_Khang testDangNhap_06_Khang = new TestDangNhap_06_Khang(
                "khangvskiss@gmail.com",
                "123123KA@"
                );

            testDangNhap_06_Khang.ExecuteLogin_06_Khang();
        }


        public void TestCase3_ValidPasswordAndEmail_06_Khang()
        {
            TestDangNhap_06_Khang testDangNhap_06_Khang = new TestDangNhap_06_Khang(
                "khangvskiss15@gmail.com",
                "123@Demo"
                );

            testDangNhap_06_Khang.ExecuteLogin_06_Khang();
        }

    }
}
