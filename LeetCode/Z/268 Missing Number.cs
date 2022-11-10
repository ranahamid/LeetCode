using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _268_Missing_Number
    {

        /// <summary>
        /// Runtime: 172 ms, faster than 28.20% of C# online submissions for Missing Number.
        /// Memory Usage: 39.8 MB, less than 93.27% of C# online submissions for Missing Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumber(int[] nums)
        {
            var n = nums.Length;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }
            return n * (n + 1) / 2 - sum;
        }

        /// <summary>
        /// Runtime: 165 ms, faster than 32.85% of C# online submissions for Missing Number.
        /// Memory Usage: 42.7 MB, less than 18.82% of C# online submissions for Missing Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumber_2(int[] nums)
        {
            var length = nums.Length + 1;
            int[] result = new int[length];
            for (int i = 0; i < length - 1; i++)
            {
                result[nums[i]] = 1;
            }
            for (int i = 0; i < length; i++)
            {
                if (result[i] == 0)
                    return i;
            }
            return -1;
        }
    }
}
