using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 190 ms, faster than 17.42% of C# online submissions for Implement Queue using Stacks.
    /// Memory Usage: 39.1 MB, less than 59.43% of C# online submissions for Implement Queue using Stacks.
    /// </summary>
    public class MyQueue
    {
        Stack<int> InStack;
        Stack<int> OutStack; 
        public MyQueue()
        {
            InStack = new Stack<int>();
            OutStack = new Stack<int>();
        }

        public void Push(int x)
        {
            InStack.Push(x);
        }
        public void FillOutStack()
        {
            if (InStack.Count != 0)
            {
                while (InStack.Count > 0)
                {
                    OutStack.Push(InStack.Pop());
                }
            }
        }
       
        public int Pop()
        {
            if (OutStack.Count != 0)
            {
                return OutStack.Pop();
            }
            FillOutStack();            
            return OutStack.Pop();
           
        }

        public int Peek()
        {
            if (OutStack.Count != 0)
            {
                return OutStack.Peek();
            }
            FillOutStack();            
            return OutStack.Peek();
          
        }

        public bool Empty()
        {
            if(InStack.Count == 0 && OutStack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
