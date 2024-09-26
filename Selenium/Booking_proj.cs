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
    internal class Booking_proj
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?aid=2369661&pagename=en-in-booking-desktop&label=msn-HiTydpHndf_KligNqm9Sgw-79852220055838:tikwd-79852393960302:loc-90:neo:mte:lp116072:dec:qsBooking.com)&utm_campaign=English_India%20EN%20IN&utm_medium=cpc&utm_source=bing&utm_term=HiTydpHndf_KligNqm9Sgw&msclkid=576d951af0441a9cdb5bf3f79ce6dbdd&utm_content=Booking%20-%20Desktop");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);

            IWebElement Closepopup = driver.FindElement(By.XPath("//button[@class='a83ed08757 c21c56c305 f38b6daa18 d691166b09 ab98298258 f4552b6561']"));
            Closepopup.Click();


            //First page-Login
            Thread.Sleep(1000);
            IWebElement Place = driver.FindElement(By.XPath("//input[@id=':rh:']"));
            Place.SendKeys("Bangalore");
            Thread.Sleep(1000);

            IWebElement Date = driver.FindElement(By.XPath("//div[@data-testid='searchbox-dates-container']"));
            Date.Click();

            IWebElement date1 = driver.FindElement(By.XPath("//span[@aria-label='24 September 2024']"));
            date1.Click();

            IWebElement members = driver.FindElement(By.XPath("//button[@data-testid=\"occupancy-config\"]"));
            members.Click();

            IWebElement Adults = driver.FindElement(By.XPath("(//button[@class='a83ed08757 c21c56c305 f38b6daa18 d691166b09 ab98298258 bb803d8689 f4d78af12a'])[1]"));
            Adults.Click();

            //IWebElement Childrens = driver.FindElement(By.XPath("(//button[@class='a83ed08757 c21c56c305 f38b6daa18 d691166b09 ab98298258 bb803d8689 f4d78af12a'])[2]"));
           // Childrens.Click();

            IWebElement Rooms = driver.FindElement(By.XPath("(//button[@class='a83ed08757 c21c56c305 f38b6daa18 d691166b09 ab98298258 bb803d8689 f4d78af12a'])[3]"));
            Rooms.Click();
            Thread.Sleep(3000);

            IWebElement Done = driver.FindElement(By.XPath("//button[@class='a83ed08757 c21c56c305 bf0537ecb5 ab98298258 a2abacf76b af7297d90d c213355c26 b9fd3c6b3c']"));
            Done.Click();
            Thread.Sleep(1000);

            IWebElement Search = driver.FindElement(By.XPath("//button[@type='submit']"));
            Search.Click();



            Thread.Sleep(1000);
            //IWebElement range1 = driver.FindElement(By.XPath("(//div[@class='b18036920b'])[1]"));
            //range1.Click();

            //IWebElement range2 = driver.FindElement(By.XPath("(//div[@class='b18036920b'])[1]"));
            //range2.Click();

            IWebElement Ratings = driver.FindElement(By.XPath("div[@xpath=\"31\"]"));
            Ratings.Click();
        }


        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
