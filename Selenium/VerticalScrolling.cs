using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class VerticalScrolling
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
            //scrolling based on coordinates x and y
            //check.... driver.ExecuteJavaScript()

            //driver.Scroll ....in selenium direct is not there - user actions class i can do the scroll
            //so have to rely on javascript scroll

            //scroll down
            //0-x coordinates
            //800 -y coordinates
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,800)",""); //x cordinate as 0 y have to give value
            Thread.Sleep(3000);


            //scroll up
            js.ExecuteScript("window.scrollBy(0,-300)", ""); //x cordinate as 0 
            Thread.Sleep(3000);

            //scroll to the bottom of the page
            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
        }


        [TearDown]
        public void teardDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }


    }
}
