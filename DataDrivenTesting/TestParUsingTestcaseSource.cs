using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilites;

namespace NUnitSelenium.DataDrivenTesting
{
    internal class TestParUsingTestcaseSource:Base
    {
        [Test,TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }
        //return type is enumeration -means set of TestData
        public static IEnumerable<TestCaseData> GetTestData()
        {
            //yield returns all the data
            yield return new TestCaseData("abc.com","ghgj");
            yield return new TestCaseData("ghh.com", "safdas");
            yield return new TestCaseData("mkk.conn", "ddffg");

        }
    }
}
