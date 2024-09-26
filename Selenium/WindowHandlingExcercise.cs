using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NUnitSelenium.Selenium
{
    internal class WindowHandlingExcercise
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //initialize the web driver
            driver = new ChromeDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //fetch the window handle of parent page
            string currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            //click on the link to open the new window
            IWebElement Open = driver.FindElement(By.XPath("//a[contains(text(),'Click Here')]"));
            Open.Click();


            IList<string> WindowsHandles = new List<string>(driver.WindowHandles);
            //the control is moved to the child window
            driver.SwitchTo().Window(WindowsHandles[1]);

            //parent and child title is different
            string title = driver.Title;
            Console.WriteLine(title);

            Assert.AreEqual("New Window", title);

            //closing of the child window
            driver.Close();
            Thread.Sleep(3000);

            //switch back to parent
            driver.SwitchTo().Window(WindowsHandles[0]);

            string title1 = driver.Title;
            Console.WriteLine(title1);

            Assert.AreEqual("The Internet", title1);
            Thread.Sleep(1000);

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
