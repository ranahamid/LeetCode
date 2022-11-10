using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1897
    {
        /// <summary>
        /// Runtime: 169 ms, faster than 29.41% of C# online submissions for Redistribute Characters to Make All Strings Equal.
        /// Memory Usage: 41.3 MB, less than 38.24% of C# online submissions for Redistribute Characters to Make All Strings Equal.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public bool MakeEqual(string[] words)
        {
            var dic = new Dictionary<char, int>();
            foreach (var item in words)
            {
                foreach (var ch in item)
                {
                    if (dic.ContainsKey(ch))
                        dic[ch]++;
                    else
                        dic[ch] = 1;
                }
            }
            foreach (var item in dic)
            {
                if (item.Value % words.Length != 0)
                    return false;
            }
            return true;
        }
    }
}
