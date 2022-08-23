using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1554
    {
        /// <summary>
        /// Runtime: 330 ms, faster than 56.10% of C# online submissions for Strings Differ by One Character.
        /// Memory Usage: 47.5 MB, less than 36.59% of C# online submissions for Strings Differ by One Character.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public bool DifferByOne(string[] dict)
        {
            int count = 0;
            string s1 = "", s2 = "";
            var len = dict[0].Length;
            for (int i = 0; i < dict.Length - 1; i++)
            {
                s1 = dict[i];
                for (int j = i + 1; j < dict.Length; j++)
                {
                    s2 = dict[j];
                    count = 0;
                    for (int k = 0; k < len; k++)
                    {
                        if (s1[k] != s2[k])
                            count++;
                        if (count > 1)
                            break;
                    }
                    if (count == 1)
                        return true;
                }
            }
            return false;
        }
        #region TLE 2
        public bool DifferByOne_2(string[] dict)
        {
            var hashset = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (var item in dict)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sb = new StringBuilder(item);
                    sb[i] = '*';
                    if (hashset.Contains(sb.ToString()))
                        return true;
                    hashset.Add(sb.ToString());
                }
            }
            return false;
        }
        #endregion
        #region TLE 1
        public bool DifferByOne_1(string[] dict)
        {
            var hashset = new HashSet<string>();
            var len = dict[0].Length;
            string sb = "";
            for (int i = 0; i < len; i++)
            {
                hashset.Clear();
                foreach (var item in dict)
                {
                    sb = item.Substring(0, i) + item.Substring(i + 1, len - i - 1);
                    if (hashset.Contains(sb))
                        return true;
                    hashset.Add(sb);
                }
            }
            return false;
        }
        #endregion
    }
}
