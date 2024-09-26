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
    internal class TABLES_AUTOMATION
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement table = driver.FindElement(By.XPath("(//table[@id='product'])[1]"));

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("(//table[@id='product'])[1]//tbody//tr"))); //all rows
            int rowCount = trrow.Count();
            Console.WriteLine(rowCount);

            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("(//table[@id='product'])[1]//tbody//tr[2]//td")));
            int colCount = tdcol.Count();
            Console.WriteLine(colCount);

            //CELL DATA
            IWebElement cellData = driver.FindElement(By.XPath("(//table[@id='product'])[1]//tbody//tr[8]//td[2]")); 
            string text = cellData.Text;
            Console.WriteLine(text);

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
