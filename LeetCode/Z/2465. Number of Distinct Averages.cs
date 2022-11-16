using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2465
    {
        /// <summary>
        /// Runtime 105 ms Beats 81.42% Memory 36.6 MB Beats 90.27%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int DistinctAverages(int[] nums)
        {
            Array.Sort(nums);
            var set = new HashSet<double>();
            var n = nums.Length;
            for (int i = 0; i < n / 2; i++)
            {
                set.Add((double)nums[i] + nums[n - i - 1]);
            }
            return set.Count;
        }
    }
}
