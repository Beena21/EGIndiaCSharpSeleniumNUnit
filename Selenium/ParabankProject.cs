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
    [Allure.NUnit.AllureNUnit]
    //[Parallelizable]
    internal class ParabankProject
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.html");
            driver.Manage().Window.Maximize();
        }

        //[Parallelizable(ParallelScope.Children)]
        [Test,Order(0),Category("Register")]
        public void testcase1_new()
        {
            Thread.Sleep(3000);

            IWebElement Registerlink = driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
            Registerlink.Click();
            Thread.Sleep(2000);

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            FirstName.SendKeys("Gauthami");

            IWebElement Lastname = driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            Lastname.SendKeys("Gauthami");

            IWebElement Address = driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Address.SendKeys("Bejai, Mangalore");

            IWebElement City = driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            City.SendKeys("Mangalore");

            IWebElement State = driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            State.SendKeys("Karnataka");

            IWebElement zipcode = driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            zipcode.SendKeys("575001");

            IWebElement phone = driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            phone.SendKeys("9999999999");

            IWebElement SSN = driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            SSN.SendKeys("12345");

            Thread.Sleep(1000);
            IWebElement username = driver.FindElement(By.XPath("//input[@id='customer.username']"));
            username.SendKeys("G111");
            Thread.Sleep(1000);
            IWebElement password = driver.FindElement(By.XPath("//input[@id='customer.password']"));
            password.SendKeys("Gauthami12345");

            IWebElement confirmpassword = driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            confirmpassword.SendKeys("Gauthami12345");

            IWebElement Registerbutton = driver.FindElement(By.XPath("//input[@value=\"Register\"]"));
            Registerbutton.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Registered");

            //IWebElement success = driver.FindElement(By.XPath("//p[contains(text(),'Your account was created successfully. You are now')]"));
            // Console.WriteLine(success.Text);

            driver.Navigate().Back();
            driver.Navigate().Back();
        }


        [Test,Order(1),Category("Login")]
        public void testcase2_new()
        {
            Thread.Sleep(1000);
            IWebElement Username_login = driver.FindElement(By.XPath("//input[@name='username']"));
            Username_login.SendKeys("G111");

            IWebElement password_login = driver.FindElement(By.XPath("//input[@name='password']"));
            password_login.SendKeys("Gauthami12345");
            Thread.Sleep(3000);
            IWebElement Login = driver.FindElement(By.XPath("//input[@value='Log In']"));
            Login.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Successful Login");
        }
            
        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
