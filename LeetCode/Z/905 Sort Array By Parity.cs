using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _905_Sort_Array_By_Parity
    {
        /// <summary>
        /// Runtime: 180 ms, faster than 67.34% of C# online submissions for Sort Array By Parity.
        /// Memory Usage: 45.6 MB, less than 25.31% of C# online submissions for Sort Array By Parity.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int[] SortArrayByParity(int[] nums)
        {
            var evenArray = nums.Where(x => x % 2 == 0).ToList();
            var oddArray = nums.Where(x => x % 2 == 1).ToList();
            evenArray.AddRange(oddArray);
            return evenArray.ToArray();

        }
    }
}
