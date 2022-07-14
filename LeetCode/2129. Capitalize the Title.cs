using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2129
    {
        /// <summary>
        /// Runtime: 173 ms, faster than 7.37% of C# online submissions for Capitalize the Title.
        /// Memory Usage: 38.3 MB, less than 60.00% of C# online submissions for Capitalize the Title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string CapitalizeTitle(string title)
        {
            var words = title.Split(' ');
            var result = new List<string>();

            foreach (var word in words)
            {
                if (word.Length > 2)
                {

                    result.Add(TitleCase(word));
                }
                else
                {
                    result.Add(word.ToLower());
                }

            }
            var data = string.Join(" ", result);
            return data;

        }
        public static string TitleCase(string s)
        {
            char[] chars = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    chars[i] = char.ToUpper(s[i]);
                }
                else
                {
                    chars[i] = char.ToLower(s[i]);
                }
            }
            return new string(chars);
        }


    }
}
