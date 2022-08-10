using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _50
    {
        /// <summary>
        /// Runtime: 18 ms, faster than 98.61% of C# online submissions for Pow(x, n).
        /// Memory Usage: 26.8 MB, less than 11.94% of C# online submissions for Pow(x, n).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow(double x, int n)
        {
            long num = n;
            if (n < 0)
            {
                x = 1 / x;
                num = n;
                num = num * -1;
            }
            return FastPow(x, num);
        }
        public double FastPow(double a, long n)
        {
            if (n == 0)
                return 1.0;
            var subSum = FastPow(a, n / 2);
            var subSquare = subSum * subSum;
            if (n % 2 == 1)
                return a * subSquare;
            else
                return subSquare;
        }
    }
}
