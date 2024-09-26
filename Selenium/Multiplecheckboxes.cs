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
    internal class Multiplecheckboxes
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
            Thread.Sleep(2000);
            //list of we elements
            IReadOnlyList<IWebElement> Checkboxes = driver.FindElements(By.XPath("//input[@type = 'checkbox']"));
            foreach (IWebElement e in Checkboxes) {
                //text of these elements ##CHEECK
                Console.WriteLine(e.Text);
                //clicks on the element ie checkbox
                e.Click();
            }

            
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
