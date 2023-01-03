using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2521
    {
        /// <summary>
        /// Runtime 134 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 51.1 MB Beats 100%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int DistinctPrimeFactors(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach (var n in nums)
            {
                var primes = GetPrimeFactors(n);
                result.UnionWith(primes);
            }
            return result.Count;
        }
        public static HashSet<int> GetPrimeFactors(int n)
        {
            HashSet<int> result = new HashSet<int>();
            while (n % 2 == 0) //315
            {
                if (!result.Contains(2))
                    result.Add(2);
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i++) // 41 
            {
                while (n % i == 0)
                {
                    if (!result.Contains(i))
                        result.Add(i);
                    n /= i;
                }
            }
            if (n > 2 && !result.Contains(n))
            {
                result.Add(n);
            }
            return result;
        }
    }
}
