using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnitSelenium.Utilites;

namespace NUnitSelenium.DataDrivenTesting
{
    internal class LoginVerifyWithInvalidCredentials:Base
    {
        [TestCase("ad", "admin123")]
        [TestCase("ad0","add")]
        [TestCase("ad1","ad2")]
        public void testcase1(string username, string password)
        {
            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(username);


            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys(password);

            IWebElement Login = driver.FindElement(By.XPath("button[type='submit']"));
            Login.Click();

            Thread.Sleep(1000);
            IWebElement Errmsg = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            string errmsg = Errmsg.Text;

            Console.WriteLine(errmsg);

            Assert.AreEqual(errmsg, "Invalid credentials");
        }
    }
}
