using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1394
    {
        /// <summary>
        /// Runtime: 147 ms, faster than 39.19% of C# online submissions for Find Lucky Integer in an Array.
        /// Memory Usage: 37.7 MB, less than 70.27% of C# online submissions for Find Lucky Integer in an Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindLucky(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map[item] = 1;
                }
            }
            var max = -1;
            foreach (var item in map)
            {
                if (item.Key == item.Value)
                {
                    max = Math.Max(max, item.Key);
                }
            }
            return max;
        }


    }
}
