using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _507
    {
        /// <summary>
        /// Runtime: 60 ms, faster than 82.42% of C# online submissions for Perfect Number.
        /// Memory Usage: 27.5 MB, less than 47.25% of C# online submissions for Perfect Number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CheckPerfectNumber(int num)
        {
            var divisors = GetDivisors(num);
            var sum = divisors.Sum();
            if (sum == num * 2)
                return true;
            return false;
        }
        private static IEnumerable<int> GetDivisors(int n)
        {
            if (n <= 0) { yield return default; }

            int iterator = (int)Math.Sqrt(n);

            for (int i = 1; i <= iterator; i++)
            {
                if (n % i == 0)
                {
                    yield return i;

                    if (i != n / i) { yield return n / i; }
                }
            }
        }
    }
}
