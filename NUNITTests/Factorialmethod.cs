using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class Factorialmethod
    {
        public int Factorial(int num)
        {
            int fact = 1;
            for(int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        

    }
}







//[Test] //extra--only if u want to do unit test in same file
//public void FactorialTest()
//{
//    int result = Factorial(5);
//    Assert.AreEqual(120, result);
//}
