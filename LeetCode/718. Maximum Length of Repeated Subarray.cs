using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _718
    {
        /// <summary>
        /// Runtime: 164 ms, faster than 86.23% of C# online submissions for Maximum Length of Repeated Subarray.
        /// Memory Usage: 42.9 MB, less than 22.46% of C# online submissions for Maximum Length of Repeated Subarray.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int FindLength(int[] nums1, int[] nums2)
        {
            var max = 0;
            var dp = new int[nums1.Length + 1, nums2.Length + 1];
            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                for (int j = nums2.Length - 1; j >= 0; j--)
                {
                    if (nums1[i] == nums2[j])
                    {
                        dp[i, j] = dp[i + 1, j + 1] + 1;
                        if (dp[i, j] > max)
                        {
                            max = dp[i, j];
                        }
                    }

                }
            }
            return max;
        }
    }
}
