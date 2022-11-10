using System.Linq;

namespace LeetCode.Z
{
    public class _4__Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            var s = nums1.ToList();
            s.AddRange(nums2);
            s.Sort();
            int len = s.Count;
            var mid = len / 2;
            if (len % 2 == 1)
            {
                return s[mid];
            }
            else
            {
                var first = (s[mid] + s[mid - 1]) / (double)2;
                return first;
            }
        }
    }
}