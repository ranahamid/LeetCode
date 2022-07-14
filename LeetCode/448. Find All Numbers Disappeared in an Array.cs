using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _448
    {
        /// <summary>
        /// Runtime: 300 ms, faster than 52.36% of C# online submissions for Find All Numbers Disappeared in an Array.
        /// Memory Usage: 48.5 MB, less than 86.12% of C# online submissions for Find All Numbers Disappeared in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var ind = Math.Abs(nums[i]) - 1;
                if (nums[ind] > 0)
                    nums[ind] = nums[ind] * -1;
            }
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    result.Add(i + 1);
            }
            return result;
        }

    }
}
