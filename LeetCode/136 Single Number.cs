using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _136_Single_Number
    {
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                    result[nums[i]]++;
                else
                    result[nums[i]] = 1;
            }
            foreach (var item in result)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }


        /// <summary>
        /// Runtime: 186 ms, faster than 21.80% of C# online submissions for Single Number.
        /// Memory Usage: 40.5 MB, less than 33.48% of C# online submissions for Single Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int SingleNumber_2(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                    result.Remove(nums[i]);
                else
                    result[nums[i]] = 1;
            }
            foreach (var item in result)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }

    }
}
