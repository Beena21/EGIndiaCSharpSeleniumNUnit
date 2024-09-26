using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    internal class PrimeNumMethod
    {
        //checking only one num
        //public string PrimeNum(int num)
        //{
        //    for(int i = 2; i < num; i++)
        //    {
        //        if (num % i == 0) return "not prime";
        //    }
        //    return "prime";
        //}


        public int[] PrimeNumMul(int[] nums)
        {
            List<int> primes = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 || nums[i] == 1) { continue; }
                else
                {
                    int flag = 0;
                    for (int j = 2; j < nums[i]; j++)
                    {
                        if (nums[i] % j == 0) { flag = 1; }
                    }
                    if (flag == 0 || nums[i] == 2) primes.Add(nums[i]);

                }
                
            }
            int[] primesarr = primes.ToArray();
            return primesarr;
        }
    }
}
