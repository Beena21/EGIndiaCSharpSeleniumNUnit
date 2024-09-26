using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class NavigationCommands
    {

        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

        }

        //selenium.dev - documentation-webdriver-interactions-navigation

        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");//launch my browser
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            driver.Navigate().Back();

            Thread.Sleep(3000);
            driver.Navigate().Forward();

            Thread.Sleep(3000);
            driver.Navigate().Refresh();
        }


        [TearDown]
        public void teardDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }

        


    }
}
