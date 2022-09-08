using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.coderbyte
{
    internal class Bracket_Combinations
    {
        public static List<string> result = new List<string>();
        public static int BracketCombinations(int n)
        {
            // code goes here  
            result = new List<string>();
            Generate(new StringBuilder(), 0, 0, n);
            return result.Count();
        }
        public static void Generate(StringBuilder current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current.ToString());
                return;
            }
            if (open < max)
            {
                current.Append("(");
                Generate(current, open + 1, close, max);
                current.Remove(current.Length - 1, 1);
            }
            if (close < open)
            {
                current.Append(")");
                Generate(current, open, close + 1, max);
                current.Remove(current.Length - 1, 1);
            }
        }
    }
}
