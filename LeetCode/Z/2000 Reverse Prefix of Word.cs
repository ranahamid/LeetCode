using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2000_Reverse_Prefix_of_Word
    {
        public static string ReversePrefix(string word, char ch)
        {
            var chars = word.ToCharArray();
            var first = new List<char>();
            var last = new List<char>();
            var isFound = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (isFound)
                {
                    last.Add(chars[i]);
                    continue;
                }
                if (chars[i] == ch)
                {
                    isFound = true;
                }
                first.Add(chars[i]);
            }
            if (isFound)
                first.Reverse();
            first.AddRange(last);
            return new string(first.ToArray());
        }
    }
}
