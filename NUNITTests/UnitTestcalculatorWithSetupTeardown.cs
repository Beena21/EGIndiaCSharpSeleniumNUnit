using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class UnitTestcalculatorWithSetupTeardown
    {
        public Calculator1 c1; //so i can use in all the methods


        [SetUp]
        public void setup()
        {
            c1 = new Calculator1();
            Console.WriteLine("Executing the Setup");
        }



        [Test]
        public void AddTest() 
        {
            int result = c1.Add(2, 3);
            int result1 = c1.Add(3, -4);
            
            Assert.AreEqual(5, result); 
            Assert.AreEqual(-1, result1); 
        }
        [Test]
        public void TestSub() 
        {
            int result = c1.Sub(5, 2);
            int result1 = c1.Sub(9, -4);
            
            Assert.AreEqual(3, result); 
            Assert.AreEqual(13, result1); 
        }

        [Test]
        public void TestMul()
        {
            int result = c1.Mul(5, 5);
            int result1 = c1.Mul(-5, 5);
            Assert.AreEqual(25, result);
            Assert.AreEqual(-25, result1);
        }
        [Test]
        public void TestDiv()
        {
            int res = c1.Div(10, 5);
            int res1 = c1.Div(-10, 5);
            Assert.AreEqual(2, res);
            Assert.AreEqual(-2, res1);
        }




        [TearDown]
        public void teardown()
        {
            Console.WriteLine("All the calculations for unit methods are executed");
        }

    }
}
