using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSelenium.Selenium
{
    internal class TakeScreenShot
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");//launch my browser
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void testcase1()
        {
            

            //Take Screenshot class and getScreenShot-method
            Screenshot ss =driver.TakeScreenshot();
            //Screenshotimage currently embedded in browser
            ss.SaveAsFile("C:\\Users\\belro\\source\\repos\\NUnitSelenium\\Screenshots\\err.jpg");
        }


        [TearDown]
        public void teardDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }


    }
}
