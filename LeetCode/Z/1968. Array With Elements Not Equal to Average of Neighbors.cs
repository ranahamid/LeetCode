using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1968
    {
        public int[] RearrangeArray(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length - 1; i = i + 2)
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            return nums;
        }
        public int[] RearrangeArray_1(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i = i + 2)
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            return nums;
        }
    }
}
