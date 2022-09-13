using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _747
    {
        /// <summary>
        /// Runtime: 86 ms, faster than 94.40% of C# online submissions for Largest Number At Least Twice of Others.
       /// Memory Usage: 38.6 MB, less than 12.69% of C# online submissions for Largest Number At Least Twice of Others.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int DominantIndex_1(int[] nums)
        {
            var max = nums.Max();
            var ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != max)
                {
                    if (max < 2 * nums[i])
                        return -1;
                }
                else
                {
                    ans = i;
                }
            }
            return ans;
        }
    }
}
