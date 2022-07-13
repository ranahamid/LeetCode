using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1119
    {
        /// <summary>
        /// Runtime: 72 ms, faster than 94.12% of C# online submissions for Remove Vowels from a String.
        /// Memory Usage: 36.8 MB, less than 11.76% of C# online submissions for Remove Vowels from a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RemoveVowels(string s)
        {
            StringBuilder sb = new StringBuilder();
            var vowels=new List<char> { 'a','e','i','o','u' };
            for(int i = 0; i < s.Length; i++)
            {
                if (!vowels.Contains(s[i]))
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
    }
}
