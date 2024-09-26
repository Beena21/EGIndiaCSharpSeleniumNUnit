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
    internal class Login
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Configure
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //helps in invoking chrome brwoser -do code fix
            //ChromeDriver driver = new ChromeDriver();//create obj of this particular Chrome Driver //configure the driver
            //potential fixes.......using OpenQA Selenium....
            driver = new ChromeDriver(); // for this  IWebDriver driver; 
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);
            //Username is the web element
            IWebElement Username = driver.FindElement(By.Name("username"));//by. here locatrs visible
            Username.SendKeys("Admin"); //Actions

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");
            
            //have to clear on type of elememt
            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
