using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2099
    {
        /// <summary>
        /// Runtime 165 ms Beats 80.33% Memory 44.4 MB Beats 11.48%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSubsequence_LINQ(int[] nums, int k)
        {
            return nums
                .Select((n, i) => new { Number = n, Index = i })
                .ToList()
                .OrderByDescending(x => x.Number)
                .Take(k)
                .OrderBy(x => x.Index)
                .Select(x => x.Number)
                .ToArray(); 

        }
        /// <summary>
        /// Runtime 144 ms Beats 95.8% Memory 43.7 MB Beats 27.87%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSubsequence(int[] nums, int k)
        {
            int[] unsortedArray2 = new int[nums.Length];
            nums.CopyTo(unsortedArray2, 0);
            Array.Sort(unsortedArray2, (left, right) => right.CompareTo(left));
            var list = unsortedArray2.Take(k).ToList(); 
            var result = new int[k];
            int i = 0;
            foreach (var n in nums)
            {
                if (list.Contains(n))
                {
                    result[i++] = n;
                    list.Remove(n);
                }
                if (i == k)
                    break;
            }
            return result;
        }
    }
}
