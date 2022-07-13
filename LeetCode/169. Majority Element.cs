﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _169
    {
        /// <summary>
        /// Runtime: 190 ms, faster than 19.80% of C# online submissions for Majority Element.
        /// Memory Usage: 40.5 MB, less than 77.01% of C# online submissions for Majority Element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (result.ContainsKey(n))
                {
                    result[n]++; 
                }
                else
                {
                    result[n] = 1;
                }
                if (result[n] > nums.Length / 2)
                {
                    return n;
                }
            } 
            return -1;
        }



    }
}