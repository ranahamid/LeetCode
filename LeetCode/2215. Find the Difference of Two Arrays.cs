using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _2215__Find_the_Difference_of_Two_Arrays {
        
        /// <summary>
        /// Runtime: 235 ms, faster than 57.14% of C# online submissions for Find the Difference of Two Arrays.
        /// Memory Usage: 46.2 MB, less than 56.39% of C# online submissions for Find the Difference of Two Arrays.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public List<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<IList<int>> result = new List<IList<int>>();
            var first = nums1.Except(nums2).ToList();
            var sec = nums2.Except(nums1).ToList();
            result.Add(first);
            result.Add(sec);
            return result;
        }
    }
}