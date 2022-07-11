using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _20
    {
        /// <summary>
        /// Runtime: 103 ms, faster than 58.13% of C# online submissions for Valid Parentheses.
        /// Memory Usage: 36.6 MB, less than 52.71% of C# online submissions for Valid Parentheses.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            var first = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    first.Push('(');
                else if (s[i] == ')')
                {
                    if (first.Count > 0 && first.Peek() == '(')
                        first.Pop();
                    else
                        return false;
                }

                if (s[i] == '{')
                    first.Push('{');
                else if (s[i] == '}')
                {
                    if (first.Count > 0 && first.Peek() == '{')
                        first.Pop();
                    else
                        return false;
                }


                if (s[i] == '[')
                    first.Push('[');
                else if (s[i] == ']')
                {

                    if (first.Count > 0 && first.Peek() == '[')
                        first.Pop();
                    else
                        return false;
                }



            }
            if (first.Count == 0)
                return true;
            else return false;
        }
    }
}
