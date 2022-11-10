using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1944
    {
        public int[] CanSeePersonsCount(int[] heights)
        {
            var result = new int[heights.Length];
            var stack = new Stack<int>();
            for (int i = 0; i < heights.Length; i++)
            {
                while (stack.Count > 0 && heights[i] >= heights[stack.Peek()])
                {
                    result[stack.Pop()]++;
                }
                if (stack.Count > 0 && heights[i] < heights[stack.Peek()])
                {
                    result[stack.Peek()]++;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
