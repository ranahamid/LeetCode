using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class HackerRank_in_a_String
    {
        public static string hackerrankInString(string s)
        {
            var sub = new StringBuilder("hackerrank");
            var counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == sub[counter])
                {
                    //counter++;
                    sub.Remove(counter, 1);
                    if (sub.Length == 0)
                        return "YES";
                }
            }
            if (sub.Length == 0)
                return "YES";
            return "NO";

        }

    }
}
