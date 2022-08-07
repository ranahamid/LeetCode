using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1874
    {
        /// <summary>
        /// Runtime: 344 ms, faster than 87.50% of C# online submissions for Minimize Product Sum of Two Arrays.
        /// Memory Usage: 55.7 MB, less than 8.33% of C# online submissions for Minimize Product Sum of Two Arrays.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int MinProductSum(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2, (a, b) => b.CompareTo(a));
            var result = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                result += nums1[i] * nums2[i];
            }
            return result;
        }
    }
}
