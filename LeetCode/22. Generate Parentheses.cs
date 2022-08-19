using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _22
    {
        /// <summary>
        /// Runtime: 224 ms, faster than 26.66% of C# online submissions for Generate Parentheses.
        /// Memory Usage: 44.1 MB, less than 90.40% of C# online submissions for Generate Parentheses.
        /// </summary>
        public static List<string> result = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            result = new List<string>();
            Generate(new StringBuilder(), 0, 0, n);
            return result;
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
