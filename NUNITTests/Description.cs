using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class Description
    {
        [Test]
        [Description("Testcase verifies login functionality with valid credentials")] //can add class level or method level
        public void testcase1()
        {
            Console.WriteLine("This is the first testcase");
        }
    }
}
