using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2293
    {
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
