using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _260
    {
        public int[] SingleNumber_Hashset(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                    result[nums[i]]++;
                else
                    result[nums[i]] = 1;
            }
            var answer = new List<int>();
            foreach (var item in result)
            {
                if (item.Value == 1)
                {
                    answer.Add(item.Key);
                }
            }
            return answer.ToArray();
        }
    }
}
