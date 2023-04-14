using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _946
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            int len = pushed.Length;
            int counter = 0;
            foreach (var n in pushed)
            {
                stack.Push(n);
                while (stack.Count > 0 && counter < len && popped[counter] == stack.Peek())
                {
                    counter++;
                    stack.Pop();
                }
            }
            return len == counter;
        }
    }
}
