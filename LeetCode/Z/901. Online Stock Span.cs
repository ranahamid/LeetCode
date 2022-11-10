using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime 397 ms Beats 96.30% Memory 68.6 MB Beats 22.2
    /// </summary>
    public class StockSpanner
    {
        Stack<(int, int)> stack;
        public StockSpanner()
        {
            stack = new Stack<(int, int)>();
        }

        public int Next(int price)
        {
            int result = 1;
            while (stack.Count > 0 && stack.Peek().Item1 <= price)
            {
                var item = stack.Pop();
                result += item.Item2;

            }
            stack.Push((price, result));
            return result;
        }
    }
}
