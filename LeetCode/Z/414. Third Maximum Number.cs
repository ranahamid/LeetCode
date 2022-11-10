using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _414
    {
        /// <summary>
        /// Runtime: 94 ms, faster than 92.77% of C# online submissions for Third Maximum Number.
        /// Memory Usage: 39.8 MB, less than 6.75% of C# online submissions for Third Maximum Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums, (a, b) => b.CompareTo(a));
            var set = new HashSet<int>(nums);
            if (set.Count >= 3)
            {
                var res = 0;
                var counter = 0;
                foreach (var item in set)
                {
                    counter++;
                    if (counter == 3)
                    {
                        return item;
                    }
                }
            }
            return set.FirstOrDefault();
        }
    }
}
