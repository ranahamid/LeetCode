using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1752
    {
        /// <summary>
        /// Runtime 137 ms Beats 69.23% Memory 38.7 MB Beats 46.15%
        /// https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/solutions/1053508/java-c-python-easy-and-concise/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool Check(int[] nums)
        {
            var counter = 0;
            var len = nums.Length;
            for (int i = 0; i < len; i++)
            {

                if (nums[i] > nums[(i + 1) % len])
                    counter++;
                if (counter > 1)
                    return false;
            }
            return true;
        }

        #region self
        public bool Check_1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Rotate(nums, 1);
                var isFlag = true;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[j - 1])
                    {
                        isFlag = false;
                        break;
                    }
                }
                if (isFlag)
                    return true;
            }
            return false;
        }
        public void Rotate(int[] nums, int k)
        {
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - 1);
        }
        #endregion
    }
}
