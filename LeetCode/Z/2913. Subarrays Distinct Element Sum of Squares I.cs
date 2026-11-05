using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2913
    {
        public int SumCounts(IList<int> nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                var set = new HashSet<int>();
                for (int j = i; j < nums.Count; j++)
                {
                    set.Add(nums[j]);
                    result += set.Count * set.Count;
                }
            }
            return result;
        }
    }
}
