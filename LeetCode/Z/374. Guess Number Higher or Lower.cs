using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _374
    {
        public int guess(int num)
        {
            return 0;
        }
        /// <summary>
        /// Runtime: 35 ms, faster than 46.34% of C# online submissions for Guess Number Higher or Lower.
        /// Memory Usage: 25.2 MB, less than 41.75% of C# online submissions for Guess Number Higher or Lower.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                var result = guess(mid);
                if (result == 0)
                {
                    return mid;
                }
                if (result == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
