using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _26_Remove_Duplicates_from_Sorted_Array
    {
        /// <summary>
        /// Runtime: 247 ms, faster than 23.77% of C# online submissions for Remove Duplicates from Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            var length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                {

                }
                else
                {
                    result.Add(nums[i], i);
                    nums[length++] = nums[i];
                }
            }
            return length;
        }
        /// <summary>
        /// Runtime: 310 ms, faster than 8.23% of C# online submissions for Remove Duplicates from Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        /// 
        public static int RemoveDuplicates_2(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            var length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!result.ContainsKey(nums[i]))
                {
                    result.Add(nums[i], i);
                    nums[length++] = nums[i];
                }
            }
            return length;
        }

        /// <summary>
        /// Runtime: 267 ms, faster than 15.49% of C# online submissions for Remove Duplicates from Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates_3(int[] nums)
        {
            var length = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[length - 1])
                {
                    nums[length++] = nums[i];
                }
            }
            return length;
        }
    }
}
