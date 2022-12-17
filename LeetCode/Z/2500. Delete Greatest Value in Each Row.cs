using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2500
    {
        /// <summary>
        /// Runtime 104 ms Beats 79.65% Memory 42.7 MB Beats 5.31%
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int DeleteGreatestValue(int[][] grid)
        {
            int sum = 0;
            var result = new List<List<int>>();
            foreach (var item in grid)
            {
                int[] unsortedArray2 = new int[item.Length];
                item.CopyTo(unsortedArray2, 0);
                Array.Sort(unsortedArray2, (left, right) => right.CompareTo(left));
                result.Add(unsortedArray2.ToList());
            }

            for (int j = 0; j < grid[0].Length; j++)
            {
                var temp = new List<int>();
                for (int i = 0; i < grid.Length; i++)
                {
                    temp.Add(result[i][j]);
                }
                sum += temp.Max();
            }
            return sum;
        }
    }
}
