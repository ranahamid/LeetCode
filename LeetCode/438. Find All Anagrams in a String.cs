using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _438
    {
        #region TLE
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            var pChar = p.ToCharArray();
            Array.Sort(pChar);
            p = new string(pChar);
            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                var subStr = s.Substring(i, p.Length);
                Array.Sort(subStr.ToArray());
                if (p == new String(subStr))
                    result.Add(i);
            }
            return result;
        }
        #endregion

    }
}
