using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class fibonacciModified
    {/// <summary>
     /// https://www.hackerrank.com/challenges/fibonacci-modified/problem?isFullScreen=true
     /// </summary>
     /// <param name="t1"></param>
     /// <param name="t2"></param>
     /// <param name="n"></param>
     /// <returns></returns>
        public static BigInteger fibonacciModified(int t1, int t2, int n)
        {
            if (n == 0)
                return t1;
            if (n == 1)
                return t2;
            var result = new BigInteger[n + 1];
            result[0] = t1;
            result[1] = t2;
            for (int i = 2; i <= n; i++)
            {
                result[i] = result[i - 1] * result[i - 1] + result[i - 2];
            }
            return result[n - 1];
        }
    }
}
