using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_81
{
    internal class _2317_Maximum_XOR_After_Operations
    {

        /// <summary>
        /// Runtime: 332 ms, faster than 100.00% of C# online submissions for Maximum XOR After Operations .
        /// Memory Usage: 47.5 MB, less than 100.00% of C# online submissions for Maximum XOR After Operations .
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaximumXOR(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result | nums[i];
            }
            return result;
        } 

    }
}
