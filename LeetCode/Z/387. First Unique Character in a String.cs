using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    class _387
    {
        /// <summary>
        /// Runtime 174 ms Beats 18.22% Memory 37.9 MB Beats 55.99%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqChar_Hash(string s)
        {
            var dic = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                dic.TryAdd(ch, 0);
                dic[ch]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dic[s[i]] == 1)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// Runtime: 114 ms, faster than 58.59% of C# online submissions for First Unique Character in a String.
        /// Memory Usage: 37.7 MB, less than 86.27% of C# online submissions for First Unique Character in a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
