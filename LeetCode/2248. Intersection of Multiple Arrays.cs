using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _2248__Intersection_of_Multiple_Arrays {
        /// <summary>
        /// Runtime: 202 ms, faster than 49.39% of C# online submissions for Intersection of Multiple Arrays.
        /// Memory Usage: 44.7 MB, less than 26.83% of C# online submissions for Intersection of Multiple Arrays.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> Intersection(int[][] nums)
        {
            var firstItem = nums[0].ToList();
            for(int i=1;i<nums.Length;i++)
            {
                firstItem= firstItem.Intersect(nums[i].ToList()).ToList();
            }

            firstItem.Sort( (a,b)=> a.CompareTo(b));
            return firstItem;
        }
    }
}