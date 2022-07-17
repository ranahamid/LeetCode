using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class Solution
    {
        public static bool IsMajorityElement(int[] nums, int target)
        {
            return nums.Count(x => x == target) > nums.Length / 2;
        }
    }
}
