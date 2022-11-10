using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _442
    {
        /// <summary>
        /// Runtime: 284 ms, faster than 59.43% of C# online submissions for Find All Duplicates in an Array.
        /// Memory Usage: 48.3 MB, less than 86.29% of C# online submissions for Find All Duplicates in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var ind = Math.Abs(nums[i]) - 1;
                if (nums[ind] < 0)
                {
                    result.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[ind] = nums[ind] * -1;
                }

            }


            return result;
        }

    }
}
