using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1855
    {
        /// <summary>
        /// Runtime: 303 ms, faster than 90.14% of C# online submissions for Maximum Distance Between a Pair of Values.
        /// Memory Usage: 55.4 MB, less than 8.45% of C# online submissions for Maximum Distance Between a Pair of Values.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int MaxDistance_3(int[] nums1, int[] nums2)
        {
            var max = 0;
            int i = 0;
            int j = 1;
            while (j < nums2.Length && i < nums1.Length)
            {
                if (nums2[j] >= nums1[i])
                {
                    j++;
                }
                else
                {
                    i++;
                }
                max = Math.Max(max, j - i - 1);
            }
            return max;
        } 
        public int MaxDistance(int[] nums1, int[] nums2)
        {
            var max = 0;
            int i = 0;
            int j = 0;
            while (j < nums2.Length - 1 && i < nums1.Length)
            {
                if (nums2[j + 1] >= nums1[i])
                {
                    j++;
                }
                else
                {
                    i++;
                }
                max = Math.Max(max, j - i);
            }
            return max;
        }
        #region TLE
        public int MaxDistance_TLE(int[] nums1, int[] nums2)
        {
            var max = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (i <= j && nums1[i] <= nums2[j])
                    {
                        max = Math.Max(max, j - i);
                    }
                }
            }
            return max;
        }
        #endregion
    }
}
