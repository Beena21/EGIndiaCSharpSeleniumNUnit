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
    internal class RadioButtons
    { //can write this prog in Checkboxes itself no need RadioButton.cs

        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Configure
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); //helps in invoking chrome brwoser -do code fix

            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);
            //for single element
            //IWebElement Checkbox2 = driver.FindElement(By.XPath("(//input[@name=\"radioButton\"])[3]"));
            //Checkbox2.Click();

            ////for list of we elements
            IReadOnlyList<IWebElement> RadioButtons = driver.FindElements(By.XPath("//input[@name=\"radioButton\"]"));
            foreach (IWebElement e in RadioButtons)
            {
                //text of these elements
                Console.WriteLine(e.Text);
                Thread.Sleep(1000);
                //clicks on the element ie checkbox
                e.Click();
            }


            ////IWebElement checkboxextra = driver.FindElement(By.XPath("//input[@name=\"radioButton\"][1]"));
            ////Console.WriteLine(checkboxextra.Text);
            ////checkboxextra.Click();
            ////
            ///The issue you’re encountering is likely because the Text property of the IWebElement is empty for input elements like checkboxes or radio buttons. These elements typically do not have any text content. Instead, you might want to check the Value attribute or the label associated with the checkbox.
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}
