using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _509_Fibonacci_Number
    {


        /// <summary>
        /// Runtime: 41 ms, faster than 46.46% of C# online submissions for Fibonacci Number.
        /// Memory Usage: 25.3 MB, less than 38.65% of C# online submissions for Fibonacci Number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            var result = new int[n + 1];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result[n];
        }
    }
}
