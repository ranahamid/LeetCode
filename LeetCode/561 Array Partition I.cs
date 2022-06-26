using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _561_Array_Partition_I
    {
        /// <summary>
        /// Runtime: 188 ms, faster than 53.27% of C# online submissions for Array Partition I.
        /// Memory Usage: 41.9 MB, less than 74.87% of C# online submissions for Array Partition I.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
