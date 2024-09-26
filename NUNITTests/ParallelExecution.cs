using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }
        [Test] //in output tests execut in order....first run this testOrders then view the output
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test]
        public void addtoCart()
        {
            Console.WriteLine("Added to Cart");
        }
    }
}
