using System.Linq;

namespace LeetCode
{
    public class _349__Intersection_of_Two_Arrays {
        
        /// <summary>
        /// Runtime: 189 ms, faster than 59.85% of C# online submissions for Intersection of Two Arrays.
        /// Memory Usage: 41.9 MB, less than 56.35% of C# online submissions for Intersection of Two Arrays.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }

    }
}