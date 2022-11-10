using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _557_Reverse_Words_in_a_String_III
    {
        /// <summary>
        /// Runtime: 195 ms, faster than 18.16% of C# online submissions for Reverse Words in a String III.
        /// Memory Usage: 41.9 MB, less than 44.34% of C# online submissions for Reverse Words in a String III.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseWords(string s)
        {
            var data = s.Split(' ');
            var result = new List<string>();
            foreach (var word in data)
            {
                var ds = word.ToCharArray();
                var ss = ds.Reverse().ToArray();
                result.Add(new string(ss));
            }
            var d = string.Join(" ", result);
            return d;
        }

    }
}
