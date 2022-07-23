using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Two_Strings
    {
        public static string twoStrings(string s1, string s2)
        {
            var map = new bool[26];
            for (int i = 0; i < s1.Length; i++)
            {
                map[s1[i] - 'a'] = true;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (map[s2[i] - 'a'])
                    return "YES";
            }
            return "NO";
        }

    }
}
