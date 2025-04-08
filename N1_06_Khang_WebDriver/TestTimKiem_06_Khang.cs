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
    public class TestTimKiem_06_Khang
    {
        private String string_06_Khang;        
        public TestTimKiem_06_Khang(String string_06_Khang)
        {
            this.string_06_Khang = string_06_Khang;
           
        }

        public TestTimKiem_06_Khang()
        {

        }

        public void ExecuteLogin_06_Khang()
        {
            ChromeDriverService chrome_06_Khang = ChromeDriverService.CreateDefaultService();
            chrome_06_Khang.HideCommandPromptWindow = true;

            // Đảm bảo rằng ChromeDriver sử dụng dịch vụ đã cấu hình
            IWebDriver driver_06_Khang = new ChromeDriver(chrome_06_Khang);
            driver_06_Khang.Navigate().GoToUrl("https://www.w3schools.com/");

            //Tim truong search bang Id
            IWebElement str_06_Khang = driver_06_Khang.FindElement(By.Id("search2"));
            str_06_Khang.SendKeys(string_06_Khang);
         
            //Tim truong button bang Id
            IWebElement searchButton_06_Khang = driver_06_Khang.FindElement(By.Id("learntocode_searchbtn"));
            searchButton_06_Khang.Click();
        }

        public void TestCase1_BlankString_06_Khang()
        {
            TestTimKiem_06_Khang testTimKiem_06_Khang = new TestTimKiem_06_Khang(
                ""
                );

            testTimKiem_06_Khang.ExecuteLogin_06_Khang();
        }

        public void TestCase2_No_Result_06_Khang()
        {
            TestTimKiem_06_Khang testTimKiem_06_Khang = new TestTimKiem_06_Khang(
                "kaskdaksd2#@dasd"
                );

            testTimKiem_06_Khang.ExecuteLogin_06_Khang();
        }


        public void TestCase3_ValidString_06_Khang()
        {
            TestTimKiem_06_Khang testTimKiem_06_Khang = new TestTimKiem_06_Khang(
                "HTML"
                );

            testTimKiem_06_Khang.ExecuteLogin_06_Khang();
        }

    }
}
