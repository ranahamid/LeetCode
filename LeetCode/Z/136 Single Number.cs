using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _136_Single_Number
    {
        /// <summary>
        /// Runtime: 149 ms, faster than 60.31% of C# online submissions for Single Number.
        /// Memory Usage: 40.1 MB, less than 60.54% of C# online submissions for Single Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber_Xor(int[] nums)
        {
            //We can use xor operation as it cancel out itself (i.e. only when values are different in binary representation then give output). See how xor operation works if confused.
            var ans = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                ans = ans ^ nums[i];
            }
            return ans;
        }
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
