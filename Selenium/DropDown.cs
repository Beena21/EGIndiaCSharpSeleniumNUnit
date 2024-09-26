using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSelenium.Selenium
{
    internal class DropDown
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Configure
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); //helps in invoking chrome brwoser -do code fix

            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown); //suggestion

            //web elemt have to be paased to new select class now
            var select = new SelectElement(DropDown);

            //select by visible text
            Thread.Sleep(1000);
            select.SelectByText("Option2");

            //Select by index
            Thread.Sleep(1000);
            select.SelectByIndex(1); //slects option1

            //Select by attreibute "value".....value="option2"
            select.SelectByValue("option3");

            //Q:Ask abt Deselct later
            


        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
