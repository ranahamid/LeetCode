using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1071
    {
        /// <summary>
        /// Runtime: 127 ms, faster than 35.79% of C# online submissions for Greatest Common Divisor of Strings.
        /// Memory Usage: 37 MB, less than 54.74% of C# online submissions for Greatest Common Divisor of Strings.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string GcdOfStrings(string str1, string str2)
        {
            var res = GCD(str1, str2);
            return res;
        }
        private static string GCD(string a, string b)
        {
            if (b.Length > a.Length)
            {
                return GCD(b, a);
            }
            else if (!a.StartsWith(b))
                return string.Empty;
            else if (b.Length == 0)
            {
                return a;
            }
            else
            {
                var data = a.Substring(b.Length);
                return GCD(data, b);
            }
        }

    }
}
