using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1952
    {
        /// <summary>
        /// Runtime: 38 ms, faster than 87.50% of C# online submissions for Three Divisors.
        /// Memory Usage: 26.8 MB, less than 87.50% of C# online submissions for Three Divisors.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsThree(int n)
        {
            if (n == 1 || n == 2)
                return false;
            var counter = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                        counter++;
                    else
                        counter = counter + 2;

                    if (counter == 3)
                        return true;
                }
            }
            return false;
        }
    }
}
