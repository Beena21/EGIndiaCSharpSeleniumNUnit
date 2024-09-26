using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    //[Allure.NUnit.AllureNUnit] //at class level-generate all the reports
    internal class AllureReportGen
    {

        [Test]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }
        [Test]
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test]
        public void addtoCart()
        {
            Console.WriteLine("Added to Cart");
        }
        //go to ur root location of ur project -folder location where my.net folder is
        //cmd
        //allure serve allure-reports
    }
}
