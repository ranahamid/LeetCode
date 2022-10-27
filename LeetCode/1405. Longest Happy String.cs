using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1405
    {
        /// <summary>
        /// Runtime 122 ms Beats 42.86% Memory 36 MB Beats 24.18%
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="lastTwoChars"></param>
        /// <returns></returns>
        public string LongestDiverseString(int a, int b, int c, string lastTwoChars = "  ")
        {
            string restriction = GetRestrictions(lastTwoChars);
            var most = getMost(a, b, c, restriction);
            if (most == "a")
                return most + LongestDiverseString(a - 1, b, c, lastTwoChars[1] + most);
            if (most == "b")
                return most + LongestDiverseString(a, b - 1, c, lastTwoChars[1] + most);
            if (most == "c")
                return most + LongestDiverseString(a, b, c - 1, lastTwoChars[1] + most);
            return String.Empty;
        }
        public string? getMost(int a, int b, int c, string restriction)
        {
            if (restriction == "a")
                return getMost(0, b, c);
            if (restriction == "b")
                return getMost(a, 0, c);
            if (restriction == "c")
                return getMost(a, b, 0);
            return getMost(a, b, c);
        }
        public string GetRestrictions(string lastTwoChars)
        {
            if (lastTwoChars == "aa")
                return "a";
            if (lastTwoChars == "bb")
                return "b";
            if (lastTwoChars == "cc")
                return "c";
            return String.Empty;
        }
        public string getMost(int a, int b, int c)
        {
            if (a > 0 && a >= b && a >= c)
                return "a";
            if (b > 0 && b >= a && b >= c)
                return "b";
            if (c > 0)
                return "c";
            return String.Empty;
        }
    }
}
