using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace NUnitSelenium.Selenium
{
    internal class Links
    {

        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();


            driver.Navigate().GoToUrl("https://www.selenium.dev/");//launch my browser
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void testcase1()
        {
            //hand icon means links....common attributes-href is a and also starts with tagname=a
            Thread.Sleep(1000);
            //store the list
            IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));
            foreach (IWebElement l in links)
            {
                //no clickong bc lot of time
                //just text od the elements
               // Console.WriteLine(l.Text); //links are printed in Tests in Console below also in Test Explorer
                
                //priting links using href....GetAttribute what attribute u want? like name or id or whole links ie href
                Console.WriteLine(l.Text + "URL is:" + l.GetAttribute("href"));

            }
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
