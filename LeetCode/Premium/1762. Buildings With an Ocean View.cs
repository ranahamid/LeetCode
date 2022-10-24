using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1762
    {
        /// <summary>
        /// Runtime 284 ms Beats 97.64% Memory 57.4 MB Beats 11.81%
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int[] FindBuildings(int[] heights)
        {
            var max = -1;
            var result = new List<int>();
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                if (heights[i] > max)
                {
                    result.Add(i);
                }
                max = Math.Max(max, heights[i]);
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
