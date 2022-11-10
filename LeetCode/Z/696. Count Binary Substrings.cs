using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _696
    {
        /// <summary>
        /// Runtime: 119 ms, faster than 27.54% of C# online submissions for Count Binary Substrings.
        /// Memory Usage: 40 MB, less than 78.74% of C# online submissions for Count Binary Substrings.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountBinarySubstrings(string s)
        {
            var resultList = new List<int>();
            char ch = s[0];
            var counter = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (ch == s[i])
                {
                    counter++;
                }
                else
                {
                    resultList.Add(counter);
                    counter = 1;
                    ch = s[i];
                }
            }
            resultList.Add(counter);

            var firstNmbr = resultList.FirstOrDefault();
            var res = 0;

            for (int i = 1; i < resultList.Count; i++)
            {
                var min = Math.Min(firstNmbr, resultList[i]);
                res += min;
                firstNmbr = resultList[i];
            }
            return res;
        }



    }
}
