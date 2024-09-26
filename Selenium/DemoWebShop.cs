using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{//Assignment
    internal class DemoWebShop
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(); 
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        { //Male
            IWebElement Gender = driver.FindElement(By.Name("Gender"));
            Gender.Click();

            //firstName
            IWebElement Firstname = driver.FindElement(By.Id("FirstName"));
            Firstname.SendKeys("ABC");
            Thread.Sleep(1000);

            IWebElement Lastname = driver.FindElement(By.Name("LastName"));
            Lastname.SendKeys("DEF");

            //CSS Selector
            IWebElement Email = driver.FindElement(By.CssSelector("#Email"));
            Email.SendKeys("abc@gmail.com");


            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("ABCDEF");

            IWebElement Confirmpassword = driver.FindElement(By.Id("ConfirmPassword"));
            Confirmpassword.SendKeys("ABCDEF");

            Thread.Sleep(2000);

            IWebElement Register = driver.FindElement(By.Id("register-button"));
            //IWebElement Register = driver.FindElement(By.LinkText("Register"));
            Register.Click();
            
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
