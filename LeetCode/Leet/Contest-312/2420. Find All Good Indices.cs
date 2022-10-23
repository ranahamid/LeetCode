using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_312
{
    internal class _2420
    {
        /// <summary>
        /// Runtime: 499 ms, faster than 100.00% of C# online submissions for Find All Good Indices.
       /// Memory Usage: 54.5 MB, less than 100.00% of C# online submissions for Find All Good Indices.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> GoodIndices(int[] nums, int k)
        {
            var right = new int[nums.Length];
            right[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    right[i] = right[i - 1] + 1;
                }
                else
                {
                    right[i] = 1;
                }
            }

            var left = new int[nums.Length];
            left[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] <= nums[i + 1])
                {
                    left[i] = left[i + 1] + 1;
                }
                else
                {
                    left[i] = 1;
                }
            }

            List<int> result = new List<int>();
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (right[i - 1] >= k && left[i + 1] >= k)
                {
                    result.Add(i);
                }
            }
            return result;

        }
    }
}
