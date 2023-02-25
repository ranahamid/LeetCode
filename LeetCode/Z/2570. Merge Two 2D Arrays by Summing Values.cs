using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2570
    {
        /// <summary>
        /// LINQ
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[][] MergeArrays_LINQ(int[][] nums1, int[][] nums2)
  => nums1.Concat(nums2).GroupBy(x => x[0]).Select(x => x.Aggregate(new int[2], (a, b) => new int[] { b[0], a[1] + b[1] })).OrderBy(x => x[0]).ToArray();

        /// <summary>
        /// Runtime: 145 ms, faster than 92.21% of C# online submissions for Merge Two 2D Arrays by Summing Values.
        /// Memory Usage: 45.7 MB, less than 32.47% of C# online submissions for Merge Two 2D Arrays by Summing Values.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[][] MergeArrays_1(int[][] nums1, int[][] nums2)
        {
            var result = new SortedDictionary<int, int>();
            foreach (var item in nums1)
            {
                result.TryAdd(item[0], item[1]);
            }
            foreach (var item in nums2)
            {
                result.TryAdd(item[0], 0);
                result[item[0]] += item[1];
            }
            var data = new int[result.Count][];
            int i = 0;
            foreach (var item in result)
            {
                data[i] = new int[2];
                data[i][0] = item.Key;
                data[i][1] = item.Value;
                i++;
            }
            return data;
        }
    }
}
