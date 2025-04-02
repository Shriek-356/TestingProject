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
        public void ExecuteSignUp_06_Khang() {

            ChromeDriverService chrome_06_Khang = ChromeDriverService.CreateDefaultService();
            chrome_06_Khang.HideCommandPromptWindow = true;

            // Đảm bảo rằng ChromeDriver sử dụng dịch vụ đã cấu hình
            IWebDriver driver_06_Khang = new ChromeDriver(chrome_06_Khang);
            driver_06_Khang.Navigate().GoToUrl("https://profile.w3schools.com/signup?redirect_url=https%3A%2F%2Fwww.w3schools.com%2F");

            //Dung XPath voi PlaceHolder
            IWebElement email_06_Khang = driver_06_Khang.FindElement(By.XPath("//input[@placeholder='email']"));
            email_06_Khang.SendKeys("example@example.com");
            Thread.Sleep(3000);

            //Dung CssSelector voi PlaceHolder
            IWebElement password_06_Khang = driver_06_Khang.FindElement(By.CssSelector("input[placeholder='password']"));
            password_06_Khang.SendKeys("KD123123");
            Thread.Sleep(3000);

            //Dung CssSelector voi PlaceHolder
            IWebElement firstname_06_Khang = driver_06_Khang.FindElement(By.CssSelector("input[placeholder='first name']"));
            firstname_06_Khang.SendKeys("Khang");
            Thread.Sleep(3000);

            //Dung CssSelector voi PlaceHolder
            IWebElement lastname_06_Khang = driver_06_Khang.FindElement(By.CssSelector("input[placeholder='last name']"));
            lastname_06_Khang.SendKeys("Duy");
            Thread.Sleep(3000);

            //Dung CssSelector voi PlaceHolder
            IWebElement signUpButton = driver_06_Khang.FindElement(By.XPath("//button[text()='Sign Up']"));
            signUpButton.Click();
            Thread.Sleep(3000);


        }
    }
}
