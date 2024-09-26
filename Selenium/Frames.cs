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
    internal class Frames
    {
        //
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl(" https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {

            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            //1way-XPath
            //driver.SwitchTo().Frame(Frame1);

            ////another way-using
            driver.SwitchTo().Frame(0); //one means error...starts from 0 so

            ////select the frame using ID or name
            //driver.SwitchTo().Frame("Frameone"); //no there in website ..so just written

            //click in the radio buton new york
            IWebElement radiobutton = driver.FindElement(By.XPath("(//label[normalize-space()='New York'])[1]"));
            radiobutton.Click();
            Thread.Sleep(1000);
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
