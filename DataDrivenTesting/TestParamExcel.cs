using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilites;
using OpenQA.Selenium;

namespace NUnitSelenium.DataDrivenTesting
{
    internal class TestParamExcel : Base
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {


            Thread.Sleep(3000);

            // Find the element usibg the By class locators 
            IWebElement Username = driver.FindElement(By.Name("username"));
            // inputing text using send keys 
            Username.SendKeys(username);


            Thread.Sleep(1000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            // inputing text using send keys 
            Password.SendKeys(password);


            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();

            Thread.Sleep(1000);

            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

            string errmsg = Errmsg.Text;

            Console.WriteLine(errmsg);

            Assert.AreEqual("Invalid credentials", errmsg);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {

            var columns = new List<string> { "username", "password" };
            //in ExcelRead.cs -file path, columns,
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\belro\\source\\repos\\NUnitSelenium\\testdata.xlsx", "LoginTest", columns);

        }

    }
}















