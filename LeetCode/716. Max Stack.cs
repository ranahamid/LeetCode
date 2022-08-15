using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    #region TLE
    public class MaxStack_TLE
    {
        Stack<int> stack;
        Stack<int> maxStack;
        public MaxStack_TLE()
        {
            stack = new Stack<int>();
            maxStack = new Stack<int>();
        }

        public void Push(int x)
        {
            var max = stack.Count == 0 ? x : maxStack.Peek();
            maxStack.Push(max > x ? max : x);
            stack.Push(x);
        }

        public int Pop()
        {
            maxStack.Pop();
            return stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int PeekMax()
        {
            return maxStack.Peek();
        }

        public int PopMax()
        {
            var max = PeekMax();

            var buffer = new Stack<int>();
            while (Top() != max)
            {
                buffer.Push(Pop());
            }
            Pop();
            while (buffer.Count > 0)
            {
                Push(buffer.Pop());
            }
            return max;
        }
    }
    #endregion
}
