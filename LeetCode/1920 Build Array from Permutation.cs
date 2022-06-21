using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1920_Build_Array_from_Permutation
    {
        /// <summary>
        /// Runtime: 264 ms, faster than 17.69% of C# online submissions for Build Array from Permutation.
        /// Memory Usage: 45.6 MB, less than 58.16% of C# online submissions for Build Array from Permutation.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] BuildArray(int[] nums)
        {
            var len = nums.Length;
            var res = new int[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = nums[nums[i]];
            }
            return res;
        }
    }
}
