using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length && nums[i] < 0; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                    TwoSum(nums, i, result);
            }
            return result;
        }
        public IList<IList<int>> TwoSum(int[] nums, int i, List<IList<int>> result)
        {
            int low = i + 1, high = nums.Length - 1;
            while (low < high)
            {
                var sum = nums[i] + nums[low] + nums[high];
                if (sum < 0)
                {
                    low++;
                }
                else if (sum > 0)
                {
                    high--;
                }
                else
                {
                    result.Add(new List<int>() { nums[i], nums[low], nums[high] });
                    low++;
                    high--;
                    while (low < high && nums[low] == nums[low - 1])
                        low++;
                }
            }
            return result;
        }
    }
}
