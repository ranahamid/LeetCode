using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1796
    {
        /// <summary>
        /// Runtime: 96 ms, faster than 52.63% of C# online submissions for Second Largest Digit in a String.
        /// Memory Usage: 35.8 MB, less than 81.58% of C# online submissions for Second Largest Digit in a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int SecondHighest(string s)
        {
            var ch = new SortedSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    ch.Add(s[i]);
            }


            if (ch.Count > 1)
            {
                var d = ch.Take(ch.Count() - 1).LastOrDefault();
                var n = int.Parse(d.ToString());
                return n;
            }
            else
                return -1;
        }
    }
}
