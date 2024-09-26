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
    internal class Tables
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement table = driver.FindElement(By.XPath("//table[@id='table1']"));

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/tr"))); //all rows
            int rowCount = trrow.Count();
            Console.WriteLine(rowCount);

            List<IWebElement> tdcol= new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/tr[1]//td"))); 
            int colCount = tdcol.Count();
            Console.WriteLine(colCount);

            //CELL DATA
            IWebElement cellData = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[2]/td[2]")); 
            string text = cellData.Text;
            Console.WriteLine(text);

            Assert.AreEqual("Frank", text);



            ////SECOND TABLE
            //IWebElement table2 = driver.FindElement(By.XPath("//table[@id='table2']"));

            //List<IWebElement> trrow2 = new List<IWebElement>(table2.FindElements(By.XPath("//table[@id='table1']/tbody/tr"))); //all rows
            //int rowCount2 = trrow.Count();
            //Console.WriteLine(rowCount2);

            //List<IWebElement> tdcol2 = new List<IWebElement>(table2.FindElements(By.XPath("//table[@id='table1']/tbody/tr[1]//td")));
            //int colCount2 = tdcol2.Count();
            //Console.WriteLine(colCount2);

            ////CELL DATA
            //IWebElement cellData2 = driver.FindElement(By.XPath("//table[@id = 'table2']/tbody/tr[2]/td[2]"));
            //string text2 = cellData2.Text;
            //Console.WriteLine(text2);

            //Assert.AreEqual("Frank", text2);

        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close();
        }
    }
}
