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
    internal class FramesExercise
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl(" https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            
            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));

            //1way-XPath
            driver.SwitchTo().Frame(Frame1);

            //click in the radio buton new york
            IWebElement radiobutton = driver.FindElement(By.XPath("(//p[normalize-space()='Your content goes here.'])[1]"));
            string content = radiobutton.Text;
            Console.WriteLine(content);

            Thread.Sleep(1000);
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
