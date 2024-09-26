using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace NUnitSelenium.DataDrivenTesting
{
    internal class TestParLogin
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }

        [Test]
        [TestCase("mkkccon", "ddffg")]
        [TestCase("ghhcon", "fghhj")]
        [TestCase("abcon", "ghhjj")]
        public void testcase1(string username,string password)
        {

            IWebElement Username = driver.FindElement(By.XPath("//input[@name='username']"));
            Username.SendKeys(username);

            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys(password);

            Thread.Sleep(1000);

            Console.WriteLine(username + ":" + password);
        }
        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
