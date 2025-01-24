using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System.Threading;
using NUnit.Framework; 

namespace Saucedemoproject.Pages
{
    public class Homepage : Basepage
    {
        private IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id,Using="user-name")] 
        public IWebElement user;
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;
       [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement Login;
       

        public Inventorypage enterdetails(string name,string pass)
        {
            Thread.Sleep(2000);
            user.SendKeys(name);
            password.SendKeys(pass);
            Login.Click();
            return new Inventorypage(driver);

        }

    }
}
