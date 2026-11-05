using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3701
    {
        public int AlternatingSum(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += nums[i];
                }
                else
                {
                    result -= nums[i];
                }
            }
            return result;
        }
    }
}
