using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1309_Decrypt_String_from_Alphabet_to_Integer_Mapping
    {
        /// <summary>
        /// Runtime: 80 ms, faster than 92.50% of C# online submissions for Decrypt String from Alphabet to Integer Mapping.
        /// Memory Usage: 35.5 MB, less than 85.83% of C# online submissions for Decrypt String from Alphabet to Integer Mapping.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FreqAlphabets(string s)
        {
            var chars = s.ToCharArray();
            List<char> result = new List<char>();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == '#')
                {
                    if (i - 1 >= 0 && i - 2 >= 0)
                    {
                        var lastDig = chars[i - 1] - 48;
                        var firstDig = chars[i - 2] - 48;
                        var num = firstDig * 10 + lastDig;
                        char ch = (char)(num + 96);
                        result.Add(ch);
                        i--; i--;
                    }
                }
                else
                {
                    int number = chars[i] - 48;
                    char ch = (char)(number + 96);
                    result.Add(ch);
                }
            }
            result.Reverse();
            var data = result.ToArray();
            var res = new string(data);
            return res;
        }
    }
}
