using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 112 ms, faster than 98.04% of C# online submissions for Implement Stack using Queues.
    /// Memory Usage: 40.3 MB, less than 7.45% of C# online submissions for Implement Stack using Queues.
    /// </summary>
    public class MyStack_QUEUE
    {
        private Queue<int> queue;
        public MyStack_QUEUE()
        {
            queue = new Queue<int>();
        }

        public void Push(int x)
        {
            queue.Enqueue(x);
            int len = queue.Count;
            while (len > 1)
            {
                queue.Enqueue(queue.Dequeue());
                len--;
            }
        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
    public class MyStack_Stack
    {
        private Stack<int> stack;
        public MyStack_Stack()
        {
            stack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}
