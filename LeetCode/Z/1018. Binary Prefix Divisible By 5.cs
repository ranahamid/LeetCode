using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1018
    {
        /// <summary>
        /// Runtime: 268 ms, faster than 46.15% of C# online submissions for Binary Prefix Divisible By 5.
        /// Memory Usage: 48.2 MB, less than 23.08% of C# online submissions for Binary Prefix Divisible By 5.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            List<bool> bools = new List<bool>();
            var ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans = (ans * 2 + nums[i]) % 5;
                bools.Add(ans == 0);
            }
            return bools;
        }
    }
}
