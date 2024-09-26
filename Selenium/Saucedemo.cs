using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{ //assignment2 
    internal class Saucedemo
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            IWebElement Username = driver.FindElement(By.CssSelector("input[placeholder='Username']"));
            Username.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");

            IWebElement Login = driver.FindElement(By.Id("login-button"));
            //IWebElement Register = driver.FindElement(By.LinkText("Register"));
            Login.Click();
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
