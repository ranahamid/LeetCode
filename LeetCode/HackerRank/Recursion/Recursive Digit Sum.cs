using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Recursion
{
    internal class Recursive_Digit_Sum
    {
        public static int superDigit(string n, int k)
        {
            var num = new StringBuilder(n);
            long sum = 0;
            var counter = 0;
            while (num.Length > 1)
            {
                sum = GetDigits(num);
                if (counter == 0)
                {
                    sum *= k;
                }
                counter++;
                num = new StringBuilder(sum.ToString());
            }
            return (int)sum;
        }

        public static long GetDigits(StringBuilder num)
        {
            long sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i] - 48;
            }
            return sum;
        }
    }
}
