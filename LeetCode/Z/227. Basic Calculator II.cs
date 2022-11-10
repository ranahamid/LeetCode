using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _227
    {
        /// <summary>
        /// without stack
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Calculate(string s)
        {
            int result = 0;
            var lastNumber = 0;
            var currentNum = 0;
            var oper = '+';
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (char.IsDigit(ch))
                {
                    currentNum = currentNum * 10 + int.Parse(ch.ToString());
                }
                if (!char.IsDigit(ch) && !char.IsWhiteSpace(ch) || i == s.Length - 1)
                {
                    if (oper == '+')
                    {
                        result += lastNumber;
                        lastNumber = currentNum;
                    }
                    else if (oper == '-')
                    {
                        result += lastNumber;
                        lastNumber = -currentNum;
                    }
                    else if (oper == '*')
                    {
                        lastNumber = lastNumber * currentNum;
                    }
                    else if (oper == '/')
                    {
                        lastNumber = lastNumber / currentNum;
                    }
                    oper = ch;
                    currentNum = 0;
                }
            }
            return result + lastNumber;
        }
        /// <summary>
        /// Stack
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Calculate_Stack(string s)
        {
            int result = 0;
            var stack = new Stack<int>();
            var currentNum = 0;
            var oper = '+';
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (char.IsDigit(ch))
                {
                    currentNum = currentNum * 10 + int.Parse(ch.ToString());
                }
                if (!char.IsDigit(ch) && !char.IsWhiteSpace(ch) || i == s.Length - 1)
                {
                    if (oper == '+')
                    {
                        stack.Push(currentNum);
                    }
                    else if (oper == '-')
                    {
                        stack.Push(-currentNum);
                    }
                    else if (oper == '*')
                    {
                        stack.Push(stack.Pop() * currentNum);
                    }
                    else if (oper == '/')
                    {
                        stack.Push(stack.Pop() / currentNum);
                    }
                    oper = ch;
                    currentNum = 0;
                }
            }
            var counter = stack.Count;
            for (int i = 0; i < counter; i++)
                result += stack.Pop();
            return result;
        }
    }
}
