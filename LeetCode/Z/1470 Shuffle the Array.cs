using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1470_Shuffle_the_Array
    {
        /// <summary>
        /// Runtime: 229 ms, faster than 22.09% of C# online submissions for Shuffle the Array.
        /// Memory Usage: 43.4 MB, less than 45.37% of C# online submissions for Shuffle the Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Shuffle(int[] nums, int n)
        {
            var result = new int[2 * n];
            var counter = 0;
            for (int i = 0; i < n; i++)
            {
                result[counter++] = nums[i];
                result[counter++] = nums[n + i];
            }
            return result;
        }
    }
}
