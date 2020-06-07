using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutoBuyer
{
    public static class JDBuyer
    {
        public static IWebDriver driver;

        static JDBuyer()
        {
            var service = EdgeDriverService.CreateDefaultService(@"C:\Users\Stone\Documents\GitHub\AutoBuyer\AutoBuyer\AutoBuyer\bin\Debug\netcoreapp3.1\DriversApplication", "msedgedriver.exe");
            string s = AppDomain.CurrentDomain.BaseDirectory + @"DriversApplication\msedgedriver.exe";
            driver = new EdgeDriver(service);
        }

        public static void Login()
        {
            driver.Navigate().GoToUrl(@"https://passport.jd.com/new/login.aspx");
            driver.FindElement(By.LinkText("账户登录")).Click();
            driver.FindElement(By.Id("loginname")).SendKeys("love13142nan");
            driver.FindElement(By.Id("nloginpwd")).SendKeys("stone13142nan%");
        }


        public static void ToNavigate()
        {
            driver.Navigate().GoToUrl(@"https://pro.jd.com/mall/active/4MmNbTkve7YDv3cqfN65jyU54rSB/index.html8");

        }

        public static void ToClick()
        {
            
            try
            {
                 IWebElement element = driver.FindElement(By.XPath(@"//*[@id='J_babelOptPage']/div/div[4]/div/div/a"));
                if (element != null)
                {
                    element.Click();

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));

                    IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("close-button")));
                    if (webElement.Displayed == true)
                    {
                        driver.FindElement(By.ClassName("close-button")).Click();
                    }
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        public static void Close()
        {
            driver.Close();
        }
    }
}
