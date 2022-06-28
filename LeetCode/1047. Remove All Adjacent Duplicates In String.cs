using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1047__Remove_All_Adjacent_Duplicates_In_String {
        
        /// <summary>
        /// Runtime: 134 ms, faster than 60.20% of C# online submissions for Remove All Adjacent Duplicates In String.
        /// Memory Usage: 39.7 MB, less than 47.04% of C# online submissions for Remove All Adjacent Duplicates In String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static string RemoveDuplicates(string s)
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