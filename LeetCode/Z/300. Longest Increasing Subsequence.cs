using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _300
    {
        /// <summary>
        /// Runtime: 92 ms, faster than 99.13% of C# online submissions for Longest Increasing Subsequence.
        /// Memory Usage: 39.7 MB, less than 22.15% of C# online submissions for Longest Increasing Subsequence.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LengthOfLIS(int[] nums)
        {
            var arrList = new List<int>();
            arrList.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > arrList.LastOrDefault())
                {
                    arrList.Add(nums[i]);
                }
                else
                {
                    int j = 0;
                    while (nums[i] > arrList[j])
                    {
                        j++;
                    }
                    arrList[j] = nums[i];
                }
            }
            return arrList.Count;
        }
    }
}
