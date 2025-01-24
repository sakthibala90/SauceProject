using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemoproject.Pages
{
    public class checkoutpagetwo
    {

        private IWebDriver driver;

        public checkoutpagetwo(IWebDriver Driver)
        {

            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How=How.Id,Using ="finish")]
        public IWebElement finishbutton;

        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement cancelbutton;

        public Checkoutthree Clickfinish()
        {
            finishbutton.Click();
            return new Checkoutthree(driver);
            
        }
        public checkoutpage cancel()
        {
            cancelbutton.Click();
            return new checkoutpage(driver);
        }
    }
}
