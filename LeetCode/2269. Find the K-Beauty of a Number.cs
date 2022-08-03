using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2269
    {
        /// <summary>
        /// Runtime: 68 ms, faster than 5.88% of C# online submissions for Find the K-Beauty of a Number.
        /// Memory Usage: 25.5 MB, less than 31.76% of C# online submissions for Find the K-Beauty of a Number.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int DivisorSubstrings(int num, int k)
        {
            var sb = num.ToString();
            var result = 0;
            for (int i = 0; i < sb.Length - k + 1; i++)
            {
                var subs = sb.Substring(i, k);
                var n = Int32.Parse(subs);
                if (n != 0 && num % n == 0)
                {
                    result++;
                }
            }
            return result;

        }
    }
}
