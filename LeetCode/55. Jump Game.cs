using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _55
    {
        /// <summary>
        /// Runtime: 178 ms, faster than 91.76% of C# online submissions for Jump Game.
       /// Memory Usage: 53 MB, less than 8.17% of C# online submissions for Jump Game.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool CanJump(int[] nums)
        {
            var lastPosition = nums.LastOrDefault();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lastPosition)
                    lastPosition = i;
            }
            return lastPosition == 0;
        }
    }
}
