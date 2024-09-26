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
    internal class SauceDemoAssign2
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //First page-Login
            Thread.Sleep(1000);
            IWebElement Username = driver.FindElement(By.CssSelector("input[placeholder='Username']"));
            Username.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");

            IWebElement Login = driver.FindElement(By.Id("login-button"));
            Login.Click();

            //Second Page-Details
            Thread.Sleep(1000);
           //##
            IWebElement Itemname = driver.FindElement(By.XPath("(//div[@class='inventory_item_name '])[1]"));
            string Name = Itemname.Text;
            string itemname = "Sauce Labs Backpack";
            Thread.Sleep(1000);
            Assert.AreEqual(Name, itemname);

            IWebElement AddToCart = driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']"));
           // IWebElement AddToCart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            AddToCart.Click();

           //top of page cart
            IWebElement Cart = driver.FindElement(By.XPath("//span[contains(text(),'1')]"));
            Cart.Click();

            //ThirdPage-Checkout
            Thread.Sleep(2000);
            IWebElement Itemname1 = driver.FindElement(By.XPath("//div[@id='']"));
            string Name1 = Itemname1.Text;
            string itemname1 = "Sauce Labs Backpack";
            //Assert.AreEqual(Name1, itemname1);

            IWebElement CheckOut = driver.FindElement(By.Id("checkout"));
            CheckOut.Click();

            //Fourth Page-entering details
            Thread.Sleep(2000);
            IWebElement Firstname = driver.FindElement(By.Id("first-name"));//by. here locatrs visible
            Firstname.SendKeys("ABC");

            IWebElement Lastname = driver.FindElement(By.Id("last-name"));//by. here locatrs visible
            Lastname.SendKeys("DEF");

            IWebElement Postalcode = driver.FindElement(By.Id("postal-code"));//by. here locatrs visible
            Postalcode.SendKeys("575001");

            IWebElement Continue = driver.FindElement(By.Id("continue"));
            Continue.Click();

            //Fifth page-payment check
            Thread.Sleep(2000);
            IWebElement Finish = driver.FindElement(By.XPath("//button[@id='finish']"));
            Finish.Click();

            //Sixth page-order complete
            Thread.Sleep(2000);
            IWebElement FinalMsg = driver.FindElement(By.XPath("//h2[contains(text(),'Thank you for your order!')]"));
            string textmsg = FinalMsg.Text;
            string expectedtext = "Thank you for your order!";
            Console.WriteLine(textmsg);
            Assert.AreEqual(textmsg, expectedtext);
        }


        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}



















//IWebElement Itemname = driver.FindElement(By.LinkText("Sauce Labs Backpack"));