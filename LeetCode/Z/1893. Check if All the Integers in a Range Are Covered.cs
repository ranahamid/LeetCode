using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1893
    {
        /// <summary>
        /// Runtime: 109 ms, faster than 75.86% of C# online submissions for Check if All the Integers in a Range Are Covered.
        /// Memory Usage: 40.6 MB, less than 10.34% of C# online submissions for Check if All the Integers in a Range Are Covered.
        /// </summary>
        /// <param name="ranges"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public bool IsCovered_2(int[][] ranges, int left, int right)
        {
            int[] seen = new int[52];
            foreach (var range in ranges)
            {
                seen[range[0]]++;
                seen[range[1] + 1]--;
            }
            for (int i = 1; i < 52; i++)
            {
                seen[i] += seen[i - 1];
            }
            for (int i = left; i <= right; i++)
            {
                if (seen[i] == 0)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Runtime: 99 ms, faster than 93.10% of C# online submissions for Check if All the Integers in a Range Are Covered.
        /// Memory Usage: 40.6 MB, less than 17.24% of C# online submissions for Check if All the Integers in a Range Are Covered.
        /// </summary>
        /// <param name="ranges"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public bool IsCovered(int[][] ranges, int left, int right)
        {
            for (int i = left; i <= right; i++)
            {
                bool isValid = false;
                foreach (var range in ranges)
                {
                    if (i >= range[0] && i <= range[1])
                    {
                        isValid = true;
                        break;
                    }
                }
                if (!isValid)
                    return false;
            }
            return true;
        }
    }
}
