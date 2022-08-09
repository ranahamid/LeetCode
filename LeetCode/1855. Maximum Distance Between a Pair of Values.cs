using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1855
    {

        #region TLE
        public int MaxDistance(int[] nums1, int[] nums2)
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
