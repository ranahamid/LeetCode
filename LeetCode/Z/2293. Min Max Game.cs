using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2293
    {
        /// <summary>
        /// Runtime: 131 ms, faster than 49.29% of C# online submissions for Min Max Game.
        /// Memory Usage: 37.5 MB, less than 92.50% of C# online submissions for Min Max Game.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinMaxGame(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var newNum = new int[nums.Length / 2];
            for (int i = 0; i < newNum.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newNum[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);

                }
                else
                {
                    newNum[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);

                }
            }
            return MinMaxGame(newNum);
        }
    }
}
