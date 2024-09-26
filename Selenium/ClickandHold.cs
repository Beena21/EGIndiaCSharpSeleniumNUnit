//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;

//namespace NUnitSelenium.Selenium
//{
//    internal class ClickandHold
//    {
//        IWebDriver driver;
//        [SetUp]
//        public void startbrowser()
//        {

//            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

//            //initialize the web driver
//            driver = new FirefoxDriver();

//            //launch the firefox browser
//            driver.Navigate().GoToUrl("https://www.amazon.in/");
//            driver.Manage().Window.Maximize();
//        }
//        [Test]
//        public void testcase1()
//        {

//            //Click and Hold on prime
//            //IWebElement Primes = driver.FindElement(By.XPath("(//span[normalize-space()='Prime'])[1]"));
//            //new Actions(driver)
//            //    .ClickAndHold(Primes) 
//            //    .Perform();
//            //Thread.Sleep(1000);
//            //Assert.AreEqual("Prime", driver.FindElement(By.XPath("(//span[normalize-space()='Prime'])[1]")).Text);

//            //another option like latest ..MOVE TO ELEMENT
//            IWebElement Primes = driver.FindElement(By.XPath("(//span[normalize-space()='Prime'])[1]"));
//            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));
//            new Actions(driver)
//                .MoveToElement(Primes)
//                .MoveToElement(LatestMovies)
//                .Perform();
//            Thread.Sleep(1000);
//            //ERROR-bcz clubbing 2 things so maybe error


//        }


//        [TearDown]
//        public void teardownbrowser()
//        {
//            driver.Close();
//        }
//    }
//}
