using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1047__Remove_All_Adjacent_Duplicates_In_String 
    {
        /// <summary>
        /// Runtime 636 ms Beats 37.44% Memory 48.1 MB Beats 8.53%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (stack.Count > 0 && stack.Peek() == ch)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }
            var counter = stack.Count;
            var sb = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                sb.Insert(0, stack.Pop());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Runtime: 134 ms, faster than 60.20% of C# online submissions for Remove All Adjacent Duplicates In String.
        /// Memory Usage: 39.7 MB, less than 47.04% of C# online submissions for Remove All Adjacent Duplicates In String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static string RemoveDuplicates_s(string s)
        {

            Stack<char> result = new Stack<char>();
            var sChars = s.ToCharArray();
            foreach (var c in sChars)
            {
                if (result.Any() && result.Peek() == c)
                {
                    result.Pop();
                }
                else
                {
                    result.Push(c);
                }
              
            }
            var d= result.Reverse().ToArray();
            return new string(d);
        }

    }
}