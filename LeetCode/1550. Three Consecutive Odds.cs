using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1550
    {
        /// <summary>
        /// Runtime: 167 ms, faster than 12.00% of C# online submissions for Three Consecutive Odds.
        /// Memory Usage: 39.5 MB, less than 52.00% of C# online submissions for Three Consecutive Odds.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            if (arr == null || arr.Length < 3)
                return false;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] % 2 == 1 && arr[i + 1] % 2 == 1 && arr[i + 2] % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
