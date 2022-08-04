using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2005
    {
        /// <summary>
        /// Runtime: 58 ms, faster than 100.00% of C# online submissions for Subtree Removal Game with Fibonacci Tree.
        /// Memory Usage: 27 MB, less than 100.00% of C# online submissions for Subtree Removal Game with Fibonacci Tree.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool FindGameWinner(int n)
        {
            return n % 6 != 1;
        }
    }
}
