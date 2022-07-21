﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _976
    {
        /// <summary>
        /// Runtime: 263 ms, faster than 5.01% of C# online submissions for Largest Perimeter Triangle.
        /// Memory Usage: 40.3 MB, less than 28.02% of C# online submissions for Largest Perimeter Triangle.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            nums = nums.Reverse().ToArray();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i + 2] + nums[i + 1] > nums[i])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }
            return 0;
        }
    }
}
