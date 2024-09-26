using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using AspectInjector.Broker;

namespace NUnitSelenium.Selenium
{
    internal class KeyboardActions
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void KeysDown()
        {
            //KeyBoard Actions - case change bc Shift Operator
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("a")//convert a to A
                .Perform();
            Thread.Sleep(3000);

        }

        public void KeysUp() 
        {
            new Actions(driver)
                .KeyUp(Keys.Shift)  //Releasing - keyup
                .SendKeys("A")
                .Perform();
            Thread.Sleep(3000);
        }

        //COntol C V


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
