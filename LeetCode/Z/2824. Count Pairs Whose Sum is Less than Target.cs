using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2824
    {
        public int CountPairs(IList<int> nums, int target)
        {
            var result = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (i != j && nums[i] + nums[j] < target)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
