using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{   //not needed this - [Allure.NUnit.AllureNUnit]
    internal class FactorialAndPrimeUnitTest
    {

        Factorialmethod f1 = new Factorialmethod();
        [Test]
        public void FactorialTest()
        {
            int result = f1.Factorial(5);
            Assert.AreEqual(120, result);
        }

        //Checking only for one number
        //    PrimeNumMethod p1 = new PrimeNumMethod();
        //    [Test]
        //    public void PrimeNumTest()
        //    {
        //        string res = p1.PrimeNum(7);
        //        Assert.AreEqual("prime", res);
        //    }



        
        PrimeNumMethod pmul = new PrimeNumMethod();
        [Test]
        public void PrimeNumTest()
        {
            int[] numbers = new int[] {0, 2,3, 5, 8, 19,49 };
            int[] res1 = pmul.PrimeNumMul(numbers);
            int[] expprimes = new int[] {2,3, 5, 19 };
            Assert.AreEqual(expprimes,res1);
        }
    }
}
