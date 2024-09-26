using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class CalculatorUnitTesting
    {
        Calculator1 c1 = new Calculator1();

        [Test]
        public void AddTest() //testing the addn method//Nunit method
        {
            int result = c1.Add(2, 3);
            int result1 = c1.Add(3, -4);
            //to validate the results-Assertion
            //Assertion on NUnit to compare the expected results with actual results
            Assert.AreEqual(5, result); //chechking exp val and actual valuue
            Assert.AreEqual(-1, result1); //-4+3
        }
        [Test]
        public void TestSub() //testing the addn method//Nunit method
        {
            int result = c1.Sub(5,2);
            int result1 = c1.Sub(9,-4);
            //to validate the results-Assertion
            //Assertion on NUnit to compare the expected results with actual results
            Assert.AreEqual(3, result); //chechking expected val and actual valuue
            Assert.AreEqual(13, result1); //-4+3
        }
        //Assignment? -mul and div 
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
    }
}
