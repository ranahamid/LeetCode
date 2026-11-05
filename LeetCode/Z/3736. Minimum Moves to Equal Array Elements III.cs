using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3736
    {
        public int MinMoves(int[] nums)
        {
            var result = 0;
            var max = nums.Max();
            foreach (var num in nums)
            {
                result += max - num;
            }
            return result;
        }
    }
}
