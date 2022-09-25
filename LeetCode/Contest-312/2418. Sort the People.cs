using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_312
{
    internal class _2418
    {
        /// <summary>
        /// Runtime: 344 ms, faster than 100.00% of C# online submissions for Sort the People.
       /// Memory Usage: 47.1 MB, less than 100.00% of C# online submissions for Sort the People.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="heights"></param>
        /// <returns></returns>
        public string[] SortPeople(string[] names, int[] heights)
        {
            var dic = new Dictionary<int, string>();
            var counter = 0;
            foreach (var h in heights)
            {
                dic.Add(h, names[counter++]);
            }
            var result = dic.OrderByDescending(x => x.Key).Select(x => x.Value);
            return result.ToArray();
        }
    }
}
