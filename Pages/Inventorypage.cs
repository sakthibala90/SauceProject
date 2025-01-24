using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Saucedemoproject.Pages
{
    public class Inventorypage:Basepage
    {
        private IWebDriver driver;

        public Inventorypage(IWebDriver Driver)
        {

            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How=How.Id,Using = "add-to-cart-sauce-labs-fleece-jacket")]
        public IWebElement jacket;
        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bolt-t-shirt")]
        public IWebElement tshirt;
        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement backpack;
        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        public IWebElement backlight;
        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        public IWebElement shoppingcart;

        public  void clickaddtocart()
        {
            jacket.Click();
        }

        public cartpage clickcart()
        {
            shoppingcart.Click();
            return new cartpage(driver);
        }

    }
}
