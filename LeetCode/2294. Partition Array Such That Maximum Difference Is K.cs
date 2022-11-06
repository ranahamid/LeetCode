using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2294
    {
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var counter = 0;
            var i = 0;
            while (i < nums.Length)
            {
                var start = nums[i];
                for (; i < nums.Length; i++)
                {
                    if (nums[i] > start + k)
                    {
                        break;
                    }
                }
                counter++;
            }
            return counter;
        }
    }
}
