using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _394
    {
        /// <summary>
        /// Runtime 78 ms Beats 97.73% Memory 36.6 MB Beats 19.51%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string DecodeString_2(string s)
        {
            var stack = new Stack<string>();
            foreach (var ch in s)
            {
                if (ch == ']')
                {
                    var word = "";
                    while (stack.Peek() != "[")
                    {
                        word = stack.Pop() + word;
                    }
                    stack.Pop();// '['
                    var revNum = "";
                    while (stack.Count > 0 && Int32.TryParse(stack.Peek(), out int a))
                    {
                        revNum = stack.Pop() + revNum;
                    }
                    Int32.TryParse(revNum, out int reverseNum);
                    var sb = new StringBuilder();
                    for (int i = 0; i < reverseNum; i++)
                    {
                        sb.Append(word);
                    }
                    stack.Push(sb.ToString());
                }
                else
                {
                    stack.Push(ch.ToString());
                }
            }
            int counter = stack.Count;
            var result = "";
            for (int i = 0; i < counter; i++)
            {
                result = stack.Pop() + result;
            }
            return result;
        }
        /// <summary>
        /// Runtime: 173 ms, faster than 5.85% of C# online submissions for Decode String.
        /// Memory Usage: 35.9 MB, less than 50.24% of C# online submissions for Decode String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string DecodeString_1(string s)
        {
            var len = s.Length;
            var counter = 0;
            var stack = new Stack<string>();
            while (counter < len)
            {
                if (s[counter] != ']')
                {
                    stack.Push(s[counter].ToString());
                }
                else
                {
                    var word = "";
                    while (stack.Peek() != "[")
                    {
                        word = stack.Pop() + word;
                    }
                    stack.Pop();//'['

                    var repeatNumStr = "";
                    while (stack.Count > 0 && Int32.TryParse(stack.Peek(), out int num))
                    {
                        repeatNumStr = stack.Pop() + repeatNumStr;
                    }
                    var repeatNum = Int32.Parse(repeatNumStr);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < repeatNum; i++)
                    {
                        sb.Append(word);
                    }
                    stack.Push(sb.ToString());
                }
                counter++;
            }
            var result = "";
            var stLen = stack.Count;
            for (int i = 0; i < stLen; i++)
            {
                result = stack.Pop() + result;
            }
            return result;
        }
    }
}
