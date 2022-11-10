using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _14
    {
        /// <summary>
        /// Runtime: 107 ms, faster than 86.40% of C# online submissions for Longest Common Prefix.
        /// Memory Usage: 39.9 MB, less than 20.56% of C# online submissions for Longest Common Prefix.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Count() == 1 && strs.First() == "") return "";
            StringBuilder sb = new StringBuilder();
            var counter = 0;
            var isTaken = true;
            var length = strs.Select(x => x.Length).ToList();
            var minLen = length.Min();

            while (isTaken && counter < minLen)
            {
                int i = 0;
                var ch = strs[i][counter];
                for (i = 1; i < strs.Length; i++)
                {
                    if (ch != strs[i][counter])
                    {
                        isTaken = false;
                        break;
                    }
                }
                if (isTaken)
                {
                    sb.Append(ch.ToString());
                }
                counter++;
            }
            return sb.ToString();
        }


    }
}
