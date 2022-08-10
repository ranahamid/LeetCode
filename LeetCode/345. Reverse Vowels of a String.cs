using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _345
    {
        /// <summary>
        /// Runtime: 108 ms, faster than 74.03% of C# online submissions for Reverse Vowels of a String.
        /// Memory Usage: 39.4 MB, less than 49.22% of C# online submissions for Reverse Vowels of a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseVowels(string s)
        {
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var list = new List<char>();
            foreach (var ch in s)
            {
                if (vowels.Contains(ch))
                {
                    list.Add(ch);
                }
            }
            StringBuilder sb = new StringBuilder(s);
            var counter = list.Count;

            for (int i = 0; i < sb.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    sb[i] = list[counter - 1];
                    counter--;
                }
            }
            return sb.ToString();
        }
    }
}
