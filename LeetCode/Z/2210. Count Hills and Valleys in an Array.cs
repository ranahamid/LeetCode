using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2210
    {
        /// <summary>
        /// Runtime: 157 ms, faster than 11.87% of C# online submissions for Count Hills and Valleys in an Array.
        /// Memory Usage: 37.1 MB, less than 52.54% of C# online submissions for Count Hills and Valleys in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int CountHillValley(int[] nums)
        {
            var hill = 0;
            var valley = 0;
            var set = new List<int>();
            var prevVal = int.MaxValue;
            foreach (int num in nums)
            {
                if (prevVal != num)
                {
                    set.Add(num);
                }
                prevVal = num;
            }
            for (int i = 1; i < set.Count - 1; i++)
            {
                if (set[i] > set[i - 1] && set[i] > set[i + 1])
                    hill++;
                if (set[i] < set[i - 1] && set[i] < set[i + 1])
                    valley++;
            }
            return hill + valley;
        }
    }
}
