using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _636
    {
        /// <summary>
        /// Runtime 269 ms Beats 51.61% Memory 46 MB Beats 85.48%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="logs"></param>
        /// <returns></returns>
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            int start = 0;
            var result = new int[n];
            var stack = new Stack<int>();
            foreach (var log in logs)
            {
                var words = log.Split(':');
                if (words[1] == "start")
                {
                    if (stack.Count > 0)
                    {
                        result[stack.Peek()] += Int32.Parse(words[2]) - start;
                    }
                    stack.Push(Int32.Parse(words[0]));
                    start = Int32.Parse(words[0]);
                }
                else
                {
                    result[stack.Pop()] += Int32.Parse(words[2]) - start + 1;
                    start = Int32.Parse(words[0]) + 1;
                }
            }
            return result;
        }
    }
}
