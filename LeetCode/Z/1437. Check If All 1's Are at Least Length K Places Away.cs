using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1437
    {
        /// <summary>
        /// Runtime: 176 ms, faster than 100.00% of C# online submissions for Check If All 1's Are at Least Length K Places Away.
        /// Memory Usage: 52.8 MB, less than 11.11% of C# online submissions for Check If All 1's Are at Least Length K Places Away.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool KLengthApart(int[] nums, int k)
        {
            var lastOne = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (lastOne == -1)
                    {
                        lastOne = i;
                        continue;
                    }
                    if (i - lastOne <= k)
                        return false;
                    lastOne = i;
                }
            }
            return true;
        }
    }
}
