using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _523
    {
        /// <summary>
        /// Runtime 455 ms Beats 71.75% Memory 51.2 MB Beats 61.7%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CheckSubarraySum(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            dic.Add(0, 0);
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dic.ContainsKey(sum % k))
                {
                    if (dic[sum % k] < i)
                        return true;
                }
                else
                    dic.Add(sum % k, i + 1);
            }
            return false;
        }
    }
}
