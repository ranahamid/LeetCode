using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1624
    {
        /// <summary>
        /// Runtime: 107 ms, faster than 26.67% of C# online submissions for Largest Substring Between Two Equal Characters.
        /// Memory Usage: 34.9 MB, less than 56.67% of C# online submissions for Largest Substring Between Two Equal Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var max = -1;
            var len = s.Length;
            var map = new Dictionary<char, int>();
            for (int i = 0; i < len; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    var val = map[s[i]];
                    max = Math.Max(max, i - val - 1);
                }
                else
                {
                    map[s[i]] = i;
                }
            }
            //if (map.Count == len)
            //    return -1;
            return max;
        }
    }
}
