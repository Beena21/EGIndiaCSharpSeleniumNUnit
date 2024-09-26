using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class Alerts
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Configure the web driver manager to set up the chrome capabilites
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //Xpath from ChroPath u paste - normalized thing shdnt copy
            IWebElement SimpleAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
            SimpleAlert.Click();

            //simple alert//switch the control to alert or popup
            IAlert alt = driver.SwitchTo().Alert();
            //click on Ok button
            alt.Accept();

            Thread.Sleep(1000);


            //confirmational alert
            IWebElement ConfAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]"));
            ConfAlert.Click();

            alt.Dismiss();
            Thread.Sleep(3000);

            //prompt alerts
            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));
            PromptAlert.Click();

            string alerttext = alt.Text;
            Console.WriteLine(alerttext);

            alt.SendKeys("Hello");
            Thread.Sleep(2000);
            alt.Accept();

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
