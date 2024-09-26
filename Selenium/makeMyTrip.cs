using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class makeMyTrip
    {
        //Date Picker
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/?msockid=03693ad8f5c06419109f2e16f45b6521");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //First page-Login
            Thread.Sleep(1000);

            IWebElement Closepopup = driver.FindElement(By.XPath("//span[@class='commonModal__close']"));
            Closepopup.Click();
            Thread.Sleep(1000);
            
            IWebElement Departure = driver.FindElement(By.XPath("//label[@for='departure']"));
            Departure.Click();
            Thread.Sleep(2000);

            //from 20 clicking on 27
           IWebElement Date = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[4]/div[6]/div[1]/p[1]"));
           // Console.WriteLine(Date.Text); gives 27
            Date.Click();
            Thread.Sleep(1000);
        }


        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
