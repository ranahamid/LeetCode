using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3925
    {
        public int[] ConcatWithReverse(int[] nums)
        {
            var result = new List<int>();
            result.AddRange(nums);
            result.AddRange(nums.Reverse());
            return result.ToArray();
        }
    }
}
