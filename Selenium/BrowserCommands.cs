using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Security.Cryptography.X509Certificates;

namespace NUnitSelenium.Selenium
{
    internal class BrowserCommands
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            
        }


        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");//launch my browser
            driver.Manage().Window.Maximize();

            //get titile of page
            string title = driver.Title;
            Console.WriteLine(title);


            //in browser-top link -get the current url
            //selenium-doc-webdriver-browsers/navigations
            string currenturl = driver.Url;
            Console.WriteLine(currenturl);

            //store the entire HTML code of this webpage
            string Pagesource = driver.PageSource;
            Console.WriteLine(Pagesource);
        }


         [TearDown]
         public void teardDownbrowser()
            {
                driver.Close(); //close ur current browser session
          }

          //wil close all the browser session of browser
          //driver.Quit();

    

    }
}
