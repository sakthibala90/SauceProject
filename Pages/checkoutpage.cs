using Microsoft.SqlServer.Server;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Saucedemoproject.Pages
{
    public class checkoutpage:Basepage
    {
        private IWebDriver driver;
        public checkoutpage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy (How=How.Id,Using = "first-name")]
        public IWebElement firstname;
        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement lastname;
        [FindsBy(How = How.Id, Using = "zipcode")]
        public IWebElement zipcode;
        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement continuebutton;
        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement cancelbutton;

        public checkoutpagetwo checkoutprocess(string fname,string lname,string zip)
        {
            firstname.SendKeys(fname);
            lastname.SendKeys(lname);
            zipcode.SendKeys(zip);
            continuebutton.Click();
            return new checkoutpagetwo(driver);
        }
        public cartpage cancel()
        {
            cancelbutton.Click();
            return new cartpage(driver);
        }
    }
}
