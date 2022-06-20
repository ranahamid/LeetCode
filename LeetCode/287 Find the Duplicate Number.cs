using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _287_Find_the_Duplicate_Number
    {

        /// <summary>
        /// Runtime: 282 ms, faster than 52.04% of C# online submissions for Find the Duplicate Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindDuplicate(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                    return nums[i];
                else
                {
                    result.Add(nums[i], i);
                }
            }
            return -1;
        }

        /// <summary>
        /// Runtime: 471 ms, faster than 5.13% of C# online submissions for Find the Duplicate Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindDuplicate_2(int[] nums)
        {
            int slow = 0, fast = 0;
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);
            fast = 0;
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }
    }
}
