using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1725
    {
        /// <summary>
        /// Runtime 192 ms Beats 67.86% Memory 40.2 MB Beats 78.57%
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        public int CountGoodRectangles(int[][] rectangles)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>(Comparer<int>.Create((a, b) => -a.CompareTo(b)));
            foreach (var item in rectangles)
            {
                var min = Math.Min(item[0], item[1]);
                dic.TryAdd(min, 0);
                dic[min]++;
            }
            return dic.FirstOrDefault().Value;
        }
    }
}
