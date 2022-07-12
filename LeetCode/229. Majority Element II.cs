using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _229
    {
        /// <summary>
        /// Runtime: 224 ms, faster than 45.89% of C# online submissions for Majority Element II.
        /// Memory Usage: 44.8 MB, less than 38.96% of C# online submissions for Majority Element II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> MajorityElement(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            var data = new HashSet<int>();
            foreach (var n in nums)
            {
                if (result.ContainsKey(n))
                {
                    result[n]++;
                }
                else
                {
                    result[n] = 1;
                }
                if (result[n] > nums.Length / 3)
                {
                    data.Add(n);
                }
            }
            return data.ToList();
        }
    }
}
