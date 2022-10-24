using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _398
    {
        /// <summary>
        /// Runtime 331 ms Beats 93.6% Memory 58.6 MB Beats 31.94%
        /// </summary>
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        public _398(int[] nums)
        {
            var counter = 0;
            foreach (var item in nums)
            {
                dic.TryAdd(item, new List<int>());
                dic[item].Add(counter);
                counter++;
            }
        }
        public int Pick(int target)
        {
            var values = dic[target];
            Random r = new Random();
            var counter = values.Count;
            var index = r.Next(0, counter);
            return values[index];

        }
    }
}
