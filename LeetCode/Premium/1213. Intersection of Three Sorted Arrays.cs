using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1213
    {
        /// <summary>
        /// Runtime: 243 ms, faster than 29.76% of C# online submissions for Intersection of Three Sorted Arrays.
        /// Memory Usage: 43.9 MB, less than 36.90% of C# online submissions for Intersection of Three Sorted Arrays.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="arr3"></param>
        /// <returns></returns>
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            var res = arr1.Intersect(arr2);
            var res2 = res.Intersect(arr3);
            return res2.ToList();
        }
    }
}
