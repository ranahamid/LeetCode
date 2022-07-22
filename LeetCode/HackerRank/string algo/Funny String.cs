using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Funny_String
    {
        public static string funnyString(string s)
        {
            var sNums = GetCharDiffCounter(s);
            var rev = s.ToCharArray().Reverse().ToArray();
            var revNums = GetCharDiffCounter(new string(rev));
            for (int i = 0; i < sNums.Count; i++)
            {
                if (sNums[i] != revNums[i])
                {
                    return "Not Funny";
                }
            }
            return "Funny";
        }
        public static List<int> GetCharDiffCounter(string s)
        {
            var result = new List<int>();
            for (int i = 0; i < s.Length - 1; i++)
            {
                result.Add(Math.Abs(s[i + 1] - s[i]));
            }
            return result;
        }

    }
}
