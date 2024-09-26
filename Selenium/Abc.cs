using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

//CHECK THIS
namespace NUnitSelenium.Selenium
{
    internal class Abc
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
            driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            
            //Username is the web element
            IWebElement Name = driver.FindElement(By.Name("name"));//by. here locatrs visible
            Name.SendKeys("Raman"); //Actions
            Thread.Sleep(1000);

            //CSS Selector
            IWebElement Email = driver.FindElement(By.CssSelector("input[placeholder='Email']"));
            Email.SendKeys("abc@gmail.com"); //name also there


            IWebElement Subject = driver.FindElement(By.Name("subject"));
            Subject.SendKeys("LeaveApplication");

            IWebElement Message = driver.FindElement(By.Id("message"));
            Message.SendKeys("Sick Down with fever");

            Thread.Sleep(2000);
            //LinkText
            //check-IWebElement Submit = driver.FindElement(By.LinkText("Submit"));
            //error-so check which works IWebElement SubmitButton = driver.FindElement(By.LinkText("Submit")); //text in the button is Submit
            IWebElement SubmitButton = driver.FindElement(By.Name("submit")); //text in selector hub is submit
            SubmitButton.Click();    
            //Alert open -means ull get a popup at top to click OK
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}















//change locators.cs
