using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _977_Squares_of_a_Sorted_Array
    {
        /// <summary>
        /// Runtime: 175 ms, faster than 94.87% of C# online submissions for Squares of a Sorted Array.
        /// Memory Usage: 59.8 MB, less than 5.29% of C# online submissions for Squares of a Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);
            return nums;
        }

    }
}
