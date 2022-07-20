using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Extra_Long_Factorials
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);
        }
    }
}
