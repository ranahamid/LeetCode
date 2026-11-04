using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3512
    {
        public int MinOperations(int[] nums, int k)
        {
            int result = 0;
            var sum = nums.Sum();
            while (sum % k != 0)
            {
                result++;
                sum--;
            }
            return result;
        }
    }
}
