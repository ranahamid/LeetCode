using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var length = nums.Length;
            var diff = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length && diff != 0; i++)
            {
                var low = i + 1;
                var high = length - 1;
                while (low < high)
                {
                    var sum = nums[i] + nums[low] + nums[high];
                    if (Math.Abs(target - sum) < Math.Abs(diff))
                    {
                        diff = target - sum;
                    }
                    if (sum < target)
                        low++;
                    else
                        high--;
                }

            }
            return target - diff;
        }
    }
}
