using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _453
    {
        /// <summary>
        /// Runtime 141 ms Beats 86.84% Memory 50.4 MB Beats 15.79%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinMoves(int[] nums)
        {
            Array.Sort(nums);
            var result = 0;
            for (int i = 1; i < nums.Length; i++)
                result += nums[i] - nums[0];
            return result;
        }
        #region brute force
        public int MinMoves_TLE(int[] nums)
        {
            var min = 0;
            var max = 0;
            int result = 0;
            while (true)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > nums[max])
                        max = i;
                    if (nums[i] < nums[min])
                        min = i;
                }
                if (nums[min] == nums[max])
                    break;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != max)
                    {
                        nums[i]++;
                    }
                }
                result++;
            }
            return result;
        }
        #endregion
    }
}
