using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V126.Audits;
using NUnitSelenium.Utilites;

namespace NUnitSelenium.Selenium
{
    internal class Links_forUtilities:Base
    {
        
        [Test]
        public void testcase1()
        {
            
            Thread.Sleep(1000);
            //store the list
            IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));
            foreach (IWebElement l in links)
            {
                Console.WriteLine(l.Text + "URL is:" + l.GetAttribute("href"));
            }
        }

    }
}
