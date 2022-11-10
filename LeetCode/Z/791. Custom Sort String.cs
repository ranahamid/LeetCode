using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _791
    {
        /// <summary>
        /// Runtime: 144 ms, faster than 21.93% of C# online submissions for Custom Sort String.
        /// Memory Usage: 36.8 MB, less than 7.89% of C# online submissions for Custom Sort String.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string CustomSortString(string order, string s)
        {
            var map = new Dictionary<char, int>();
            var counter = 0;
            foreach (var item in order)
            {
                map[item] = counter++;
            }
            StringBuilder sb = new StringBuilder(s);
            StringBuilder result = new StringBuilder();
            var data = map.OrderBy(x => x.Value).ToList();
            foreach (var item in data)
            {
                var key = item.Key;
                var value = item.Value;
                if (s.Contains(key))
                {
                    var count = s.Count(x => x == key);
                    for (int i = 0; i < count; i++)
                    {
                        result.Append(key);
                        var index = sb.ToString().IndexOf(key);
                        sb.Remove(index, 1);
                    }
                }

            }
            result.Append(sb);
            return result.ToString();
        }

    }
}
