using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1063
    {
        /// <summary>
        /// Runtime: 342 ms, faster than 100.00% of C# online submissions for Number of Valid Subarrays.
        /// Memory Usage: 42.9 MB, less than 100.00% of C# online submissions for Number of Valid Subarrays.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ValidSubarrays(int[] nums)
        {
            var result = 0;
            var stack = new Stack<int>();
            foreach (var num in nums)
            {
                while (stack.Count > 0 && stack.Peek() > num)
                    stack.Pop();
                stack.Push(num);
                result += stack.Count();
            }
            return result;
        }
    }
}
