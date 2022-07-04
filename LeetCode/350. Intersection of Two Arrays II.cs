using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            return Intersect2(nums1, nums2).ToArray();
        }
        public static IEnumerable<T> Intersect2<T>(IEnumerable<T> source, IEnumerable<T> target)
        {
            List<T> list = target.ToList();
            foreach (T item in source)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                    yield return item;
                }
            }
        }
    } 
}
