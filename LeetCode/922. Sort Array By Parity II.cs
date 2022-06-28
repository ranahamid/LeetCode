using System;
using System.Linq;

namespace LeetCode
{
    public class _922__Sort_Array_By_Parity_II {
        
        /// <summary>
        /// Runtime: 179 ms, faster than 86.55% of C# online submissions for Sort Array By Parity II.
        /// Memory Usage: 53.8 MB, less than 5.04% of C# online submissions for Sort Array By Parity II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SortArrayByParityII(int[] nums)
        {
            
            Array.Sort(nums);
            var odd = nums.Where(x => x % 2 == 1).ToArray();
            var even = nums.Where(x => x % 2 == 0).ToArray();
            var oddCounter = 0;
            var evenCounter = 0;
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result[i] = odd[oddCounter++];
                }
                else
                {
                    result[i] = even[evenCounter++];
                }
            }

            return result;
        }



    }
}