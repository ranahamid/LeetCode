using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _150
    {
        /// <summary>
        /// Runtime: 167 ms, faster than 11.74% of C# online submissions for Evaluate Reverse Polish Notation.
        /// Memory Usage: 38.7 MB, less than 56.10% of C# online submissions for Evaluate Reverse Polish Notation.
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public static int EvalRPN(string[] tokens)
        {
            int result = 0;
            Stack<string> stack = new Stack<string>(result);
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    var last = stack.Pop();
                    var first = stack.Pop();
                    Int32.TryParse(last, out int lastNum);
                    Int32.TryParse(first, out int firstNum);
                    var sum = 0;
                    if (tokens[i] == "+")
                        sum = firstNum + lastNum;
                    else if (tokens[i] == "-")
                        sum = firstNum - lastNum;
                    else if (tokens[i] == "*")
                        sum = firstNum * lastNum;
                    else if (tokens[i] == "/")
                        sum = firstNum / lastNum;
                    // result += sum;
                    stack.Push(sum.ToString());
                }
                else
                {
                    stack.Push(tokens[i]);
                }
            }
            var st = stack.Pop();
            Int32.TryParse(st, out int lastN);
            return lastN;
        }

    }
}
