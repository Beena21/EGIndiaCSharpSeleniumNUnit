using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    [TestFixture,Category("Smoke")] //category to your class level
    internal class CategoryTesting
    {
        [Test,Category("Regression")]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }
        //[Test,Category("Sanity")]  //in output tests execut in order....first run this testOrders then view the output
        //[Test, Category("Sanity,Regression")] //multiple category at method level
        
        //marks with test method to be ignored - give warning msg but not fail
        [Test,Ignore("Defect ID 45667")] //ignored this test case bcz defect in this test case
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test,Category("Regression")] //traits

        //whole description of test case shd be there - to make client understand -add description layer-Description.cs
        public void addtoCart()
        {
            Console.WriteLine("Added to Cart");
        }
    }
}
