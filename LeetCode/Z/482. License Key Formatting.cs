using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _482
    {
        /// <summary>
        /// Runtime: 113 ms, faster than 85.77% of C# online submissions for License Key Formatting.
        /// Memory Usage: 53 MB, less than 5.14% of C# online submissions for License Key Formatting.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string LicenseKeyFormatting(string s, int k)
        {
            var temp = new StringBuilder();
            var result = new List<StringBuilder>();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '-')
                {
                    temp.Append(char.ToUpper(s[i]));
                    if (temp.Length == k)
                    {
                        result.Add(new StringBuilder(new string(temp.ToString().Reverse().ToArray())));
                        temp = new StringBuilder();
                    }
                }
            }
            if (temp.Length > 0)
                result.Add(new StringBuilder(new string(temp.ToString().Reverse().ToArray())));

            var answer = new StringBuilder();
            for (int i = result.Count - 1; i >= 0; i--)
            {
                answer.Append(result[i]);
                if (i != 0)
                    answer.Append("-");
            }
            return answer.ToString();
        }
    }
}
