using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _283_Move_Zeroes
    {
        /// <summary>
        /// Runtime: 182 ms, faster than 85.04% of C# online submissions for Move Zeroes.
        /// Memory Usage: 54.2 MB, less than 7.12% of C# online submissions for Move Zeroes.
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            var nonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex++] = nums[i];
                }
            }

            if (nonZeroIndex < nums.Length)
            {
                for (int i = nonZeroIndex; i < nums.Length; i++)
                {
                    nums[i] = 0;
                }
            }
        }
    }
}
