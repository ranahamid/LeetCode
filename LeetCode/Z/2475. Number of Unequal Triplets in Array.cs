using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2475
    {
        /// <summary>
        /// Runtime 160 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 36.8 MB Beats 100%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int UnequalTriplets(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    for (int k = j + 1; k < nums.Length; k++)
                        if (nums[i] != nums[j] && nums[j] != nums[k] && nums[i] != nums[k])
                            counter++;
            return counter;
        }
    }
}
