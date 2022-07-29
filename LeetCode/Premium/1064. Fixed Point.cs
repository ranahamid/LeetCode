using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1064
    {
        /// <summary>
        /// Runtime: 138 ms, faster than 37.84% of C# online submissions for Fixed Point.
        /// Memory Usage: 38.9 MB, less than 48.65% of C# online submissions for Fixed Point.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FixedPoint(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > i)
                    return -1;
                if (i == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
