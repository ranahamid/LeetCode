using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_86
{
    internal class _2395
    {
        /// <summary>
        /// Runtime: 177 ms, faster than 100.00% of C# online submissions for Find Subarrays With Equal Sum.
        /// Memory Usage: 39.2 MB, less than 100.00% of C# online submissions for Find Subarrays With Equal Sum.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool FindSubarrays(int[] nums)
        {
            if (nums.Length < 3)
                return false;
            var setDic = new Dictionary<long, int>();
            long sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                if (i >= 2)
                {
                    sum -= nums[i - 2];
                }
                if (setDic.ContainsKey(sum))
                    return true;
                else
                    setDic[sum] = 1;
            }
            return false;
        }
    }
}
