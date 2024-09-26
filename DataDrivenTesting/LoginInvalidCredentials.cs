using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.DataDrivenTesting
{
    internal class LoginInvalidCredentials
    {
        //TestParUsingLogin
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //or you can write this in Base class and LoginInvalidCredentials:Base

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }


        [TestCase("Admin", "admin123")]
        public void testcase1(string username, string password)
        {
            IWebElement Username = driver.FindElement(By.XPath("//input[@name='username']"));
            Username.SendKeys(username);


            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys(password);

            IWebElement Login = driver.FindElement(By.XPath("button[type='submit']"));
            Login.Click();

            Thread.Sleep(1000);

            //####check vedio-11:39

           
        }
        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
