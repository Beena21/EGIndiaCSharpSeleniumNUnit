using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
   // [TestFixture,Category("Smoke")]
    internal class testOrders
    {
        [Test,Order(1)]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }
        [Test,Order(2)] //in output tests execut in order....first run this testOrders then view the output
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test,Order(3)]
        public void addtoCart()
        {
            Console.WriteLine("Added to Cart");
        }
    }
}
