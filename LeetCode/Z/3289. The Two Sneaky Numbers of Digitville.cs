using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3289
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            var result = new List<int>();
            var cnt = new int[100];
            for (int i = 0; i < nums.Length; i++)
            {

                cnt[nums[i]]++;
                if (cnt[nums[i]] > 1)
                {
                    result.Add(nums[i]);
                }
            }
            return result.ToArray();
        }
    }
}
