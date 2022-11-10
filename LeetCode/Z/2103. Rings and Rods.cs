using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2103
    {
        /// <summary>
        /// Runtime: 89 ms, faster than 62.74% of C# online submissions for Rings and Rods.
        /// Memory Usage: 35 MB, less than 40.20% of C# online submissions for Rings and Rods.
        /// </summary>
        /// <param name="rings"></param>
        /// <returns></returns>
        public int CountPoints(string rings)
        {
            var dic = new Dictionary<char, HashSet<char>>();
            for (int i = 0; i < rings.Length; i = i + 2)
            {
                if (dic.ContainsKey(rings[i + 1]))
                {
                    dic[rings[i + 1]].Add(rings[i]);
                }
                else
                {
                    dic[rings[i + 1]] = new HashSet<char>();
                    dic[rings[i + 1]].Add(rings[i]);
                }
            }
            var count = dic.Where(x => x.Value.Count() == 3).Count();
            return count;
        }
    }
}
