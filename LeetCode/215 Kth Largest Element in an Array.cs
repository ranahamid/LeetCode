﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _215_Kth_Largest_Element_in_an_Array
    {
        /// <summary>
        /// Runtime: 179 ms, faster than 11.94% of C# online submissions for Kth Largest Element in an Array.
        /// Memory Usage: 38.5 MB, less than 52.71% of C# online submissions for Kth Largest Element in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public int FindKthLargest(int[] nums, int k)
        {
            var list = nums.ToList();
            list.Sort();
            nums = list.ToArray();
            return nums[nums.Count() - k];
        }
    }
}