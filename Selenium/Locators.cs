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
    internal class Locators
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); 
            
            driver = new ChromeDriver(); 
            driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement Name = driver.FindElement(By.Name("name"));
            Name.SendKeys("Raman");
            Thread.Sleep(1000);

            IWebElement Email = driver.FindElement(By.CssSelector("input[placeholder='Email']"));
            Email.SendKeys("abc@gmail.com"); 


            IWebElement Subject = driver.FindElement(By.Name("subject"));
            Subject.SendKeys("LeaveApplication");

            IWebElement Message = driver.FindElement(By.Id("message"));
            Message.SendKeys("Sick Down with fever");

            Thread.Sleep(2000);
           
            IWebElement SubmitButton = driver.FindElement(By.Name("submit"));
            SubmitButton.Click();
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
