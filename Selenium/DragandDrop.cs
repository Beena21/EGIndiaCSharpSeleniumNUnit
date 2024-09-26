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
    internal class DragandDrop
    {
       
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl(" https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {

            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));

            IWebElement Destination = driver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(driver)
                .DragAndDrop(Source, Destination)
                .Perform();
            Thread.Sleep(3000);

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
