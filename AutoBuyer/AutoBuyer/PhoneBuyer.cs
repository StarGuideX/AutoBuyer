using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace AutoBuyer
{
    public class PhoneBuyer
    {
        IWebDriver driver;
        public void Login()
        {

            var service = EdgeDriverService.CreateDefaultService(@"C:\Users\Stone\Documents\GitHub\AutoBuyer\AutoBuyer\AutoBuyer\bin\Debug\netcoreapp3.1\DriversApplication", "msedgedriver.exe");

            string s = AppDomain.CurrentDomain.BaseDirectory + @"DriversApplication\msedgedriver.exe";
            driver = new EdgeDriver(service);
            driver.Navigate().GoToUrl(@"https://passport.jd.com/new/login.aspx");
            driver.FindElement(By.LinkText("账户登录")).Click();
            driver.FindElement(By.Id("loginname")).SendKeys("love13142nan");
            driver.FindElement(By.Id("nloginpwd")).SendKeys("stone13142nan%");
        }

        public void ToNavigate()
        {
            driver.Navigate().GoToUrl(@"https://pro.jd.com/mall/active/4MmNbTkve7YDv3cqfN65jyU54rSB/index.html8");

        }

        public void ToClick()
        {
            driver.FindElement(By.XPath(@"//*[@id='J_babelOptPage']/div/div[7]/div/div/a")).Click();
        }

        public void sss2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));

            try
            {
                IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("close-button")));
                if (webElement.Displayed == true)
                {
                    driver.FindElement(By.ClassName("close-button")).Click();
                }
            }
            catch (Exception)
            {

            }
        }

        public void Close()
        {
            driver.Close();
        }
    }
}
