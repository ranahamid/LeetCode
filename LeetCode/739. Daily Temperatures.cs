using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _739
    {
        /// <summary>
        /// Runtime 314 ms Beats 97.27% Memory 57.6 MB Beats 6.10%
        /// </summary>
        /// <param name="temperatures"></param>
        /// <returns></returns>
        public int[] DailyTemperatures(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var stack = new Stack<int>();
            for (int i = 0; i < temperatures.Length; i++)
            {
                var current = temperatures[i];
                while (stack.Count > 0 && temperatures[stack.Peek()] < current)
                {
                    var previous = stack.Pop();
                    result[previous] = i - previous;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
