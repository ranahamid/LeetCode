using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1550
    {
        /// <summary>
        /// Runtime: 125 ms, faster than 62.00% of C# online submissions for Three Consecutive Odds.
        /// Memory Usage: 39.2 MB, less than 86.00% of C# online submissions for Three Consecutive Odds.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool ThreeConsecutiveOdds(int[] arr)
        {

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
