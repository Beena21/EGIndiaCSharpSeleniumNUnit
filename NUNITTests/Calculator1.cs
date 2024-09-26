using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class Calculator1
    {
        //Addition operation
        public int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        //subtraction
        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }

        //multiplication
        public int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }
        //Division
        public int Div(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
