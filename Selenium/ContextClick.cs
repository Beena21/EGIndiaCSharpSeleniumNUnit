using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class ContextClick
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {

            //Double CLick
            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));
            new Actions(driver)
                .ContextClick(TdyDeal) //Right click,but cant be beyond it
                .Perform();
            Thread.Sleep(1000);
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
