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
    internal class FileUpload
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id='file-upload']"));
            ChooseFile.SendKeys("C:\\Users\\belro\\OneDrive - EG A S\\Desktop\\HR1.png");
            //ChooseFile.SendKeys("C:\\Users\\belro\\OneDrive - EG A S\\Desktop\\Test.pdf");
            
            IWebElement Upload = driver.FindElement(By.XPath("//input[@id ='file-submit']"));
            Upload.Click();

            Thread.Sleep(1000);

            IWebElement FileUploadMsg = driver.FindElement(By.XPath("//h3[contains(text(),'File Uploaded!')]"));
            string textmsg = FileUploadMsg.Text;
            string expectedtext = "File Uploaded!";
            Console.WriteLine(textmsg);
            Assert.AreEqual(textmsg,expectedtext);

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
