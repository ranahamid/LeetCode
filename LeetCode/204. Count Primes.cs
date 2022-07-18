using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _204
    {
        /// <summary>
        /// Runtime: 399 ms, faster than 20.52% of C# online submissions for Count Primes.
        /// Memory Usage: 118.1 MB, less than 5.21% of C# online submissions for Count Primes.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountPrimes(int n)
        {
            var isPrime = new int[n];
            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = 1;
            }
            var counter = 0;
            for (int i = 2; i * i < n; i++)
            {
                if (isPrime[i] == 0)
                    continue;
                for (int j = i * i; j < n; j = j + i)
                {
                    isPrime[j] = 0;
                }
            }
            counter = isPrime.Where(x => x == 1).Count();
            return counter;
        }
    }
}
