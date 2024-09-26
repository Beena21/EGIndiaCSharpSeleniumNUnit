using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilites;


namespace NUnitSelenium.ParallelExecution
{
    //[Parallelizable]
    internal class ParallelExecutionusingTestParams:Base
    {
        //[Parallelizable(ParallelScope.Children)]
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd-_HH-mm-ss");
            Console.WriteLine(username + ":" + password +".............."+time);
        }
        
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("abc.com", "ghgj");
            yield return new TestCaseData("ghh.com", "safdas");
            yield return new TestCaseData("mkk.conn", "ddffg");

        }
    }
}
