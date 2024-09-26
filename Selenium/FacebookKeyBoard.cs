using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class FacebookKeyBoard
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void KeysDown()
        {

            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("abc")
                .KeyUp(Keys.Shift)
                .SendKeys("@gmail.com")
                .Perform();
           
            Thread.Sleep(3000);

            //// Convert the email to uppercase and send it to the email field
            //string email = "abc@example.com";
            //new Actions(driver)
            //    .KeyDown(Keys.Shift)
            //    .SendKeys(email)
            //    .Perform();
            //Thread.Sleep(2000);
            ////emailField.SendKeys(email.ToUpper());

        }



        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
