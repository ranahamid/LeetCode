using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1680
    {
        /// <summary>
        /// Runtime: 246 ms, faster than 50.00% of C# online submissions for Concatenation of Consecutive Binary Numbers.
        /// Memory Usage: 26.3 MB, less than 50.00% of C# online submissions for Concatenation of Consecutive Binary Numbers.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ConcatenatedBinary(int n)
        {
            //https://leetcode.com/problems/concatenation-of-consecutive-binary-numbers/discuss/2612407/C%2B%2B-or-Diagram-or-Related-Problems
            long result = 0;
            long BIGMOD = (long)Math.Pow(10, 9) + 7;
            for (int i = 1; i <= n; i++)
            {
                var length = NumberOfBits(i);
                result = ((result << length) % BIGMOD + i);
            }
            return (int)result;
        }
        public int NumberOfBits(int n)
        {
            return (int)Math.Log(n, 2) + 1;
        }
        /// <summary>
        /// Runtime: 3419 ms, faster than 33.33% of C# online submissions for Concatenation of Consecutive Binary Numbers.
        ///  Memory Usage: 28.3 MB, less than 50.00% of C# online submissions for Concatenation of Consecutive Binary Numbers.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ConcatenatedBinary_1(int n)
        {
            var result = 0;
            var BIGMOD = Math.Pow(10, 9) + 7;
            for (int i = 1; i <= n; i++)
            {
                var binary = Convert.ToString(i, 2);
                for (int j = 0; j < binary.Length; j++)
                {
                    var temp = binary[j] - '0';
                    result = (int)((result * 2 + temp) % BIGMOD);
                }
            }
            return result;
        }
    }
}
