using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class The_Love_Letter_Mystery
    {
        public static int theLoveLetterMystery(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                result += Math.Abs(s[s.Length - 1 - i] - s[i]);
            }
            return result;
        }

    }
}
