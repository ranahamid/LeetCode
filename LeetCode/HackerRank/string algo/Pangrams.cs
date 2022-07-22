using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Pangrams
    {
        public static string pangrams(string s)
        {
            var result = new bool[26];
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    result[char.ToLower(s[i]) - 'a'] = true;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == false)
                    return "not pangram";
            }
            return "pangram";
        }
    }
}
