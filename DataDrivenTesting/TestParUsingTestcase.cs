using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.DataDrivenTesting
{
    internal class TestParUsingTestcase
    {
        //for parameterization have to go to the test case
        [Test]
        [TestCase("ab.con", "ghhjj")] //password
        [TestCase("ghh.con", "fghhj")]
        [TestCase("mkk.con", "ddffg")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);

        }
    }
}
