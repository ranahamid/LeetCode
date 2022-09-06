using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _255
    {
        /// <summary>
        /// Runtime: 133 ms, faster than 85.71% of C# online submissions for Verify Preorder Sequence in Binary Search Tree.
        /// Memory Usage: 49.6 MB, less than 14.29% of C# online submissions for Verify Preorder Sequence in Binary Search Tree.
        /// </summary>
        /// <param name="preorder"></param>
        /// <returns></returns>
        public bool VerifyPreorder(int[] preorder)
        {
            var stack = new Stack<int>();
            var low = Int32.MinValue;
            foreach (var num in preorder)
            {
                if (num < low)
                    return false;
                while (stack.Count > 0 && num > stack.Peek())
                {
                    low = stack.Pop();
                }
                stack.Push(num);
            }
            return true;
        }
    }
}
