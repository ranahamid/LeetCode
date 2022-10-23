using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_81
{
    internal class _6104_Count_Asterisks
    {
        /// <summary>
        /// Runtime: 115 ms, faster than 100.00% of C# online submissions for Count Asterisks.
        /// Memory Usage: 34.8 MB, less than 100.00% of C# online submissions for Count Asterisks.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountAsterisks(string s)
        {
            var chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '|')
                {
                    i++;
                    while (chars[i] != '|')
                    {
                        chars[i] = '-';
                        i++;
                    }
                }
            }
            var count = chars.Where(x => x == '*').Count();
            return count;
        }
    }
}
