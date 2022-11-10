using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
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
            var restrictions = GetRestrictions(lastTwoChars);
            var mostChar = GetMost(a, b, c, restrictions);
            if (mostChar == "a") return mostChar + LongestDiverseString(a - 1, b, c, lastTwoChars[1] + mostChar);
            if (mostChar == "b") return mostChar + LongestDiverseString(a, b - 1, c, lastTwoChars[1] + mostChar);
            if (mostChar == "c") return mostChar + LongestDiverseString(a, b, c - 1, lastTwoChars[1] + mostChar);
            return string.Empty;
        }
        public static string GetRestrictions(string lastTwoChars)
        {
            if (lastTwoChars == "aa") return "a";
            if (lastTwoChars == "bb") return "b";
            if (lastTwoChars == "cc") return "c";
            return string.Empty;
        }
        public static string GetMost(int a, int b, int c, string restrictions)
        {
            if (restrictions == "a") return GetMost(0, b, c);
            if (restrictions == "b") return GetMost(a, 0, c);
            if (restrictions == "c") return GetMost(a, b, 0);
            return GetMost(a, b, c);
        }
        public static string GetMost(int a, int b, int c)
        {
            if (a > 0 && a >= b && a >= c) return "a";
            if (b > 0 && b >= c && b >= c) return "b";
            if (c > 0) return "c";
            return string.Empty;
        }
    }
}
