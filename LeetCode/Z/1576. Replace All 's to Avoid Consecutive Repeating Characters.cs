using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1576
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 78.38% of C# online submissions for Replace All ?'s to Avoid Consecutive Repeating Characters.
        /// Memory Usage: 39.5 MB, less than 18.92% of C# online submissions for Replace All ?'s to Avoid Consecutive Repeating Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ModifyString(string s)
        {
            var sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '?')
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sb[i] = (char)(j + 97);
                        if ((i == 0 || sb[i - 1] != sb[i]) && (i == sb.Length - 1 || sb[i] != sb[i + 1]))
                            break;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
