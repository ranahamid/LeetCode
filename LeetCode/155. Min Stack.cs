using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    #region fastest 
    /// <summary>
    /// Runtime: 159 ms, faster than 77.58% of C# online submissions for Min Stack.
    /// Memory Usage: 46.8 MB, less than 49.92% of C# online submissions for Min Stack.
    /// </summary>
    public class MinStack
    {
        Stack<(int, int)> stack;
        public MinStack()
        {
            stack = new Stack<(int, int)>();
        }

        public void Push(int val)
        {
            var min = stack.Count == 0 ? val : stack.Peek().Item2 < val ? stack.Peek().Item2 : val;
            stack.Push((val, min));
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek().Item1;
        }

        public int GetMin()
        {
            return stack.Peek().Item2;
        }
    }
    #endregion
    #region slow
    /// <summary>
    /// Runtime: 1129 ms, faster than 5.08% of C# online submissions for Min Stack.
    /// Memory Usage: 47.2 MB, less than 30.55% of C# online submissions for Min Stack.
    /// </summary>
    public class MinStack_2
    {
        Stack<int> stack;
        public MinStack_2()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return stack.Min();
        }
    }
    #endregion


    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
