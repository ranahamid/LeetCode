using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_308
{
    internal class _2390
    {
        public string RemoveStars(string s)
        {
            StringBuilder t = new StringBuilder();
            foreach (var c in s)
            {
                if (c != '*')
                    t.Append(c);
                else
                    t.Remove(t.Length - 1, 1);
            }
            return t.ToString();
        }

        /// <summary>
        /// Runtime: 154 ms, faster than 100.00% of C# online submissions for Removing Stars From a String.
        /// Memory Usage: 41 MB, less than 100.00% of C# online submissions for Removing Stars From a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RemoveStars_2(string s)
        {
            var builder = new StringBuilder();
            var totalCount = s.Length - 1;
            var sumOfStar = 0;
            while (totalCount >= 0)
            {
                if (s[totalCount] == '*')
                {
                    while (s[totalCount] == '*')
                    {
                        sumOfStar++;
                        totalCount--;
                    }
                }
                var limit = sumOfStar;
                for (int index = 0; index < limit; index++)
                {
                    if (s[totalCount] == '*')
                        break;
                    totalCount--;
                    sumOfStar--;
                }
                if (totalCount >= 0 && s[totalCount] != '*')
                {
                    builder.Append(s[totalCount]);
                    totalCount--;
                }
            }
            var result = new string(builder.ToString().Reverse().ToArray());
            return result;
        }
    }
}
