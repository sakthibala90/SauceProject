using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace Saucedemoproject.Pages
{
    public  class cartpage:Basepage
    {
        private IWebDriver driver;

        public cartpage(IWebDriver Driver)
        {

            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy (How=How.Id,Using= "checkout")]
        public IWebElement checkout;

        public checkoutpage clickcheckout()
        {
            checkout.Click();
            return new checkoutpage(driver);
        }
        
    }
}
