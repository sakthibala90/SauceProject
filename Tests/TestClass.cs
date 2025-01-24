using Microsoft.Win32.SafeHandles;
using NUnit.Framework;
using OpenQA.Selenium;
using Saucedemoproject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Saucedemoproject.Tests
{
    public class TestClass : Basepage
    {
        
        
        [Test] 
        public void Test()
        {

            Homepage hom = new Homepage(driver);
            Inventorypage inv=hom.enterdetails("standard_user", "secret_sauce");
            inv.clickaddtocart();
            Thread.Sleep(1000);
           cartpage cat= inv.clickcart();
            checkoutpage checkp= cat.clickcheckout();
           checkoutpagetwo page2=checkp.checkoutprocess("sakthi", "bl", "628002");
           Checkoutthree ch3= page2.Clickfinish();
            ch3.getText();
            

        }
    }
}
