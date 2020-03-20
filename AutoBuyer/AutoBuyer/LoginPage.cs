using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoBuyer.JD
{
    public class LoginPage : LoadableComponent<LoginPage>
    {
        private readonly IWebDriver driver;
        private GSPFluentInterface gspfi;

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        public class GSPFluentInterface
        {
            private LoginPage gsp;

            public GSPFluentInterface(LoginPage googleSearchPage)
            {
                gsp = googleSearchPage;
            }

            public GSPFluentInterface clickSearchButton()
            {
                gsp.searchButton.click();
                return this;
            }

            public GSPFluentInterface setSearchString(String sstr)
            {
                clearAndType(gsp.searchField, sstr);
                return this;
            }
        }

        public LoginPage(IWebDriver driver)
        {
            gspfi = new GSPFluentInterface(this);
            this.get(); // If load() fails, calls isLoaded() until page is finished loading
            PageFactory.initElements(driver, this); // Initialize WebElements on page
        }
    }
}
