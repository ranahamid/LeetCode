using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _658
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var sorted = arr.OrderBy(y => Math.Abs(y - x)).Take(k).ToArray();
            Array.Sort(sorted);
            return sorted;
        }
    }
}
