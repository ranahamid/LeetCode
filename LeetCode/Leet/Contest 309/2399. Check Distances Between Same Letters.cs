using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_309
{
    internal class _2399
    {
        /// <summary>
        /// Runtime: 156 ms, faster than 100.00% of C# online submissions for Check Distances Between Same Letters.
        /// Memory Usage: 40.9 MB, less than 100.00% of C# online submissions for Check Distances Between Same Letters.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool CheckDistances(string s, int[] distance)
        {
            var setDic = new Dictionary<char, int>();
            for (int index = 0; index < s.Length; index++)
            {
                var ch = s[index];
                if (setDic.ContainsKey(ch))
                {
                    setDic[ch] = index - setDic[ch];
                }
                else
                {
                    setDic[ch] = index + 1;
                }
            }
            for (int index = 0; index < distance.Length; index++)
            {
                if (setDic.ContainsKey((char)(index + 97)))
                {
                    var val = setDic[(char)(index + 97)];
                    if (distance[index] != val)
                        return false;
                }
            }
            return true;
        }
    }
}
