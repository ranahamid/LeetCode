using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _55
    {
       
        #region Greedy

        /// <summary>
        /// Runtime: 178 ms, faster than 91.76% of C# online submissions for Jump Game.
        /// Memory Usage: 53 MB, less than 8.17% of C# online submissions for Jump Game.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        /// Greedy
        public bool CanJump_1(int[] nums)
        {
            var lastPosition = nums.LastOrDefault();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lastPosition)
                    lastPosition = i;
            }
            return lastPosition == 0;
        }
        #endregion
        #region backtracking -TLE
        public bool Jump(int[] nums, int position)
        {
            if (position == nums.Length - 1)
                return true;
            int minPosition = Math.Min(nums.Length - 1, position + nums[position]);
            for (int next = position + 1; next <= minPosition; next++)
            {
                if (Jump(nums, next))
                    return true;
            }
            return false;
        }
        public bool CanJump_2(int[] nums)
        {
            return Jump(nums, 0);
        }
        #endregion
    }
}
