using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _389
    {
        /// <summary>
        /// Runtime: 160 ms, faster than 16.87% of C# online submissions for Find the Difference.
        /// Memory Usage: 38.3 MB, less than 38.80% of C# online submissions for Find the Difference.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static char FindTheDifference(string s, string t)
        {
            var sF = GetFrequency(s);
            var tF = GetFrequency(t);
            foreach (var item in tF)
            {
                if (sF.ContainsKey(item.Key))
                {
                    var valF = sF[item.Key];
                    var valT = tF[item.Key];
                    if (valF < valT)
                        return item.Key;
                }
                else
                {
                    return item.Key;
                }
            }
            return 'A';
        }
        public static Dictionary<char, int> GetFrequency(string s)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (frequency.ContainsKey(s[i]))
                {
                    frequency[s[i]]++;
                }
                else
                {
                    frequency[s[i]] = 1;
                }
            }
            return frequency;
        }

    }
}
