using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class reverseInParentheses
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/reverse-substrings-between-each-pair-of-parenthesis/
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>

        string solution(string inputString)
        {

            var stack = new Stack<int>();
            for (int i = 0; i < inputString.Length; i++)
            {

                if (inputString[i] == '(')
                {
                    stack.Push(i);
                }
                else if (inputString[i] == ')')
                {
                    char[] a = inputString.ToCharArray();
                    reverse(a, stack.Peek() + 1, i);
                    inputString = new string(a);
                    stack.Pop();
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ')' && inputString[i] != '(')
                    sb.Append(inputString[i]);
            }
            return sb.ToString();
        }
        public void reverse(char[] a, int l, int r)
        {
            if (l < r)
            {
                (a[l], a[r]) = (a[r], a[l]);
                reverse(a, l + 1, r - 1);
            }
        }
    }
}
