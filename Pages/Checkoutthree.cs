using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemoproject.Pages
{
    public class Checkoutthree:Basepage
    {
        private IWebDriver driver;

        public Checkoutthree(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "back-to-products")]
        public IWebElement Backtohome;
        [FindsBy(How = How.XPath, Using = "//h2[@class='complete-header']")]
        public IWebElement Wor;
        public void getText()
        {
            string s = Wor.Text;
            Assert.Equals(s, "Thank you for your order!");
        }
        public Homepage clickBack2home()
        {
            Backtohome.Click();
        return new Homepage(driver);
        }

        
    }
}
