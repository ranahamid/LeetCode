using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _961_N_Repeated_Element_in_Size_2N_Array
    {
        /// <summary>
        /// Runtime: 109 ms, faster than 99.02% of C# online submissions for N-Repeated Element in Size 2N Array.
        /// Memory Usage: 47.9 MB, less than 11.76% of C# online submissions for N-Repeated Element in Size 2N Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RepeatedNTimes(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                {
                    return nums[i];
                }
                else
                {
                    result.Add(nums[i], 1);
                }
            }
            return 0;
        }
    }
}
