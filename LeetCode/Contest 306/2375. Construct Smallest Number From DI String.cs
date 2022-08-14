using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_306
{
    internal class _2375
    {
        /// <summary>
        /// Runtime: 134 ms, faster than 100.00% of C# online submissions for Construct Smallest Number From DI String.
        /// Memory Usage: 35.8 MB, less than 100.00% of C# online submissions for Construct Smallest Number From DI String.
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public string SmallestNumber(string pattern)
        {
            Stack<int> stack = new Stack<int>();
            int num = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 'D')
                {
                    stack.Push(num);
                    num++;
                }
                else
                {
                    sb.Append(num.ToString()); 
                    num++;
                    while (stack.Count > 0)
                    {
                        sb.Append(stack.Pop());
                    }
                }
            }
            stack.Push(num);
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            return sb.ToString();
        }
    }
}
