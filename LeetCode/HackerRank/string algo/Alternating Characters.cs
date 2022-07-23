using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Alternating_Characters
    {
        public static int alternatingCharacters(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    result++;
            }
            return result;
        }
    }
}
