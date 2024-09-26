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
    internal class LaunchFirefox
    {
        IWebDriver driver; //mam getting error-codefix
        [SetUp]
        public void startbrowser()
        {
            //configure
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); //helps in invoking chrome brwoser -do code fix
            //initialize
            driver = new FirefoxDriver(); 

        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");//launch my browser
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
