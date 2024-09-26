using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Runtime.CompilerServices;

namespace NUnitSelenium.Selenium
{
    internal class FileDownload
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Configure the web driver manager to set up the chrome capabilites
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //a[contains(text(),'Jpeg_with_exif.jpeg')]
            IWebElement ChooseFile = driver.FindElement(By.XPath("//a[contains(text(),'123.jpg')]"));
            ChooseFile.Click();

            //check the presence of particular file in the folder
            string text = ChooseFile.Text; //gives filename

            string path = "C:\\Users\\belro\\Downloads" + text;
            Assert.That(File.Exists(path));


        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
