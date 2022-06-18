using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Isomorphic_Strings
    {
        /// <summary>
        /// Runtime: 115 ms, faster than 40.87% of C# online submissions for Isomorphic Strings.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<string, string> sData = new Dictionary<string, string>();
            Dictionary<string, string> tData = new Dictionary<string, string>();

            for (int i = 0; i < s.Length; i++)
            {
                var sChar = s[i].ToString();
                var tChar = t[i].ToString();
                if (sData.ContainsKey(sChar))
                {
                    var currentVal = sData[sChar];
                    if (currentVal != tChar)
                        return false;
                }
                else
                {
                    sData.Add(sChar, tChar);
                }

                if (tData.ContainsKey(tChar))
                {
                    var currentVal = tData[tChar];
                    if (currentVal != sChar)
                        return false;
                }
                else
                {
                    tData.Add(tChar, sChar);
                }

            }
            return true;
        }
    }
}
