using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class LaunchBrowserChrome
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //Configure
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //helps in invoking chrome brwoser -do code fix
            //ChromeDriver driver = new ChromeDriver();//create obj of this particular Chrome Driver //configure the driver
            //potential fixes.......using OpenQA Selenium....
            driver = new ChromeDriver(); // for this  IWebDriver driver; 
        }

        [Test]
        public void testcase1()
        {
            //launch my browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
