using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class SetupTearDown
    {
        [SetUp]//called immediately before each test case to be run
        public void setup1()
        {
            Console.WriteLine("Launching Chrome Browser");
        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("Closing Chrome Browser");
        }



        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }
        [Test, Order(2)]
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test, Order(3)]
        public void addtoCart()
        {
            Console.WriteLine("Added to Cart");
        }
    }
}
