using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckDomain
{


    class CheckDomain
    {
        private ChromeDriver dr;


        public CheckDomain(string email , string password)
        {
            dr = new ChromeDriver();
            dr.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 0, 15);
            dr.Url = "https://www.pinterest.com/login/?referrer=home_page";
            dr.FindElementByName("id").SendKeys(email);
            dr.FindElementByName("password").SendKeys(password);
            dr.FindElementByCssSelector("form > button").Click();
        }

        public void CheckThisDomain(string domain,string cleardomain)
        {
            try
            {
                dr.Url = domain;
                var wait = new WebDriverWait(dr, new TimeSpan(0, 0, 0, 30));
                wait.Until(x => x.FindElement(OpenQA.Selenium.By.CssSelector("#PinPanePinMeta")));

                dr.FindElementByCssSelector("[role = button]").Click();
                

                Thread.Sleep(5000);

                var link = dr.FindElementByLinkText("See it now");
                File.AppendAllText("good.txt", cleardomain + Environment.NewLine);

                return;

            }
            
            catch (Exception ex)
            {
                File.AppendAllText("hvnresult.txt", cleardomain + Environment.NewLine);
            }
           
            


        }
    }

    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
