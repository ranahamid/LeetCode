using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1608
    {
        /// <summary>
        /// Runtime: 148 ms, faster than 15.93% of C# online submissions for Special Array With X Elements Greater Than or Equal X.
        /// Memory Usage: 39.7 MB, less than 8.85% of C# online submissions for Special Array With X Elements Greater Than or Equal X.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SpecialArray(int[] nums)
        {
            var arr = new int[10001];
            foreach (var item in nums)
            {
                arr[item]++;
            }
            int sum = 0;
            for (int i = 1000; i >= 0; i--)
            {
                sum += arr[i];
                if (sum == i)
                    return i;
            }
            return -1;
        }
    }
}
