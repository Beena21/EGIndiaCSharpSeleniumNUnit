using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace NUnitSelenium.Selenium
{
    internal class Checkboxes
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Configure
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); //helps in invoking chrome brwoser -do code fix
            
            driver = new FirefoxDriver(); 
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);
            //single line checkbox
            IWebElement Checkbox2 = driver.FindElement(By.XPath("(//input[@type = 'checkbox'])[1]"));
            Checkbox2.Click();

            //IWebElement Checkbox3 = driver.FindElement(By.XPath("(//input[@type = 'checkbox'])[2]"));
            //Checkbox3.Click();

            //if u want both check box-for loop...check

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
