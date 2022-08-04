using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _41
    {
        /// <summary>
        /// Runtime: 260 ms, faster than 89.19% of C# online submissions for First Missing Positive.
        /// Memory Usage: 68.5 MB, less than 33.46% of C# online submissions for First Missing Positive.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FirstMissingPositive(int[] nums)
        {
            var isExist = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 1)
                {
                    isExist++;
                    break;
                }
            }
            if (isExist == 0)
                return 1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 || nums[i] > n)
                {
                    nums[i] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                var a = Math.Abs(nums[i]);
                if (a == n)
                {
                    nums[0] = -Math.Abs(nums[0]);
                }
                else
                {
                    nums[a] = -Math.Abs(nums[a]);
                }
            }
            for (int i = 1; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i;
                }
            }
            if (nums[0] > 0)
            {
                return n;
            }
            return n + 1;

        }



        /// <summary>
        /// Runtime: 402 ms, faster than 34.62% of C# online submissions for First Missing Positive.
        /// Memory Usage: 61.8 MB, less than 73.68% of C# online submissions for First Missing Positive.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FirstMissingPositive_2(int[] nums)
        {
            Array.Sort(nums);
            var isExist = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == isExist)
                {
                    isExist++;
                }
                else if (nums[i] > isExist)
                {
                    break;
                }
            }
            return isExist;
        }

    }
}
