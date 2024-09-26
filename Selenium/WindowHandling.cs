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
    internal class WindowHandling
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver
            driver = new FirefoxDriver();

            //launch the firefox browser
            driver.Navigate().GoToUrl(" https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //fetch the window handle of parent page
            string currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            //click on the link to open the new window
            IWebElement Open = driver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            Open.Click();


            IList<string> WindowsHandles = new List<string>(driver.WindowHandles);
            //the control is moved to the child window
            driver.SwitchTo().Window(WindowsHandles[1]);    //control is on child windows  WindowsHandles(1).

            //parent and child title is different
            string title = driver.Title;
            Console.WriteLine(title);

            Assert.AreEqual("Simple Page", title);

            //closing of the child window
            driver.Close();
            Thread.Sleep(3000);

            //switch back to parent
            driver.SwitchTo().Window(WindowsHandles[0]);
            //driver.SwitchTo().DefaultContent();
            string title1 = driver.Title;
            Console.WriteLine(title1);
            
            Assert.AreEqual("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow",title1);


        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
