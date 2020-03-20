using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace AutoBuyer
{
    class JDBuyer
    {
        public void s() 
        {
            IWebDriver driver = new EdgeDriver("/path/to/msedgedriver.exe");
            driver.Get("");
            driver.Navigate().GoToUrl(@"https://www.jd.com/");


            // PageFactory.newInstance(AccountPage.class);
        }
    }

    public class LoginPage : LoadableComponent
    { 
    
    }
}
