using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _844
    {
        /// <summary>
        /// Runtime: 100 ms, faster than 63.82% of C# online submissions for Backspace String Compare.
        /// Memory Usage: 36.8 MB, less than 75.00% of C# online submissions for Backspace String Compare.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool BackspaceCompare(string s, string t)
        {
            if (GetDeletedWord(s) == GetDeletedWord(t))
                return true;
            return false;
        }
        public static string GetDeletedWord(string s)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch != '#')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
            }

            var st = new List<char>();
            while (stack.Count > 0)
            {
                st.Add(stack.Pop());
            }
            return new string(st.ToArray());
        }
    }
}
