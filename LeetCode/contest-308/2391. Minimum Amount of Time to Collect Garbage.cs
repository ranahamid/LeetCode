using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_308
{
    internal class _2391
    {
        /// <summary>
        /// Runtime: 551 ms, faster than 100.00% of C# online submissions for Minimum Amount of Time to Collect Garbage.
        /// Memory Usage: 93.7 MB, less than 100.00% of C# online submissions for Minimum Amount of Time to Collect Garbage.
        /// </summary>
        /// <param name="garbage"></param>
        /// <param name="travel"></param>
        /// <returns></returns>
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            var sb = new List<StringBuilder>();
            for (int i = 0; i < garbage.Length; i++)
            {
                sb.Add(new StringBuilder(garbage[i]));
            }
            var total = 0;
            var items = new List<char> { 'P', 'G', 'M' };
            for (int k = 0; k < 3; k++)
            {
                var pickItem = items[k];
                int res = 0;
                int lastItem = 0;
                for (int i = 0; i < sb.Count; i++)
                {
                    var charArra = sb[i].ToString().ToCharArray();
                    var counter = charArra.Where(x => x == pickItem).Count();
                    if (counter > 0)
                    {
                        res += counter;
                        lastItem = i;
                    }
                    if (i < travel.Length)
                        res += travel[i];
                }
                for (int i = garbage.Count() - 2; i >= lastItem; i--) //did not count the first one, so -2
                {
                    res -= travel[i];
                }
                total += res;
            }
            return total;
        }
    }
}
