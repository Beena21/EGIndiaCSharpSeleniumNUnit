using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSelenium.Selenium
{
    internal class ActionsEg
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

            //remove interactions package then write below line
            //Actions actions = new Actions();
            //actions.

            //Action act = new Action();
            //act
            //.
            //new Actions(driver)
            //    .Context

            //Double CLick
            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));
            new Actions(driver)
                .DoubleClick(TdyDeal)
                .Perform(); //v.imp
            Thread.Sleep(1000);



        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
