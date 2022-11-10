using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1646
    {
        /// <summary>
        /// Runtime: 33 ms, faster than 56.18% of C# online submissions for Get Maximum in Generated Array.
        /// Memory Usage: 25.7 MB, less than 40.45% of C# online submissions for Get Maximum in Generated Array.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetMaximumGenerated(int n)
        {
            if (n == 0) return 0;
            var nums = new int[n + 1];
            nums[1] = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i * 2 <= n)
                {
                    nums[2 * i] = nums[i];
                }
                if (i * 2 + 1 <= n)
                {
                    nums[2 * i + 1] = nums[i] + nums[i + 1];
                }
            }
            return nums.Max();
        }
    }
}
