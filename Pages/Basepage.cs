using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Saucedemoproject.Pages
{
    public class Basepage
    {
        public IWebDriver driver;

        [SetUp]
        public void setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            driver.Url="https://www.saucedemo.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }

    }
}
