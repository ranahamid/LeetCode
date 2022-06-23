using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2176_Count_Equal_and_Divisible_Pairs_in_an_Array
    {
        /// <summary>
        /// Runtime: 80 ms, faster than 100.00% of C# online submissions for Count Equal and Divisible Pairs in an Array.
        /// Memory Usage: 39.5 MB, less than 18.18% of C# online submissions for Count Equal and Divisible Pairs in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public static int CountPairs(int[] nums, int k)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && (i * j) % k == 0)
                    {
                        result++;
                    }
                }
            }
            return result;

        }


    }
}
