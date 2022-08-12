using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1426
    {
        /// <summary>
        /// Runtime: 94 ms, faster than 80.00% of C# online submissions for Counting Elements.
        /// Memory Usage: 38.3 MB, less than 60.00% of C# online submissions for Counting Elements.
     /// </summary>
     /// <param name="arr"></param>
     /// <returns></returns>
        public int CountElements(int[] arr)
        {
            var set = new HashSet<int>(arr);
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i] + 1))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
