using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2005
    {
        /// <summary>
        /// Runtime: 49 ms, faster than 100.00% of C# online submissions for Subtree Removal Game with Fibonacci Tree.
        //// Memory Usage: 26.8 MB, less than 100.00% of C# online submissions for Subtree Removal Game with Fibonacci Tree.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool FindGameWinner(int n)
        {
            return n % 6 != 1;
        }
    }
}
