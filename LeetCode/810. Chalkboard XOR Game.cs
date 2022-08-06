using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _810
    {
        /// <summary>
        /// Runtime: 102 ms, faster than 100.00% of C# online submissions for Chalkboard XOR Game.
        /// Memory Usage: 42.3 MB, less than 14.29% of C# online submissions for Chalkboard XOR Game
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool XorGame(int[] nums)
        {
            if (nums.Length % 2 == 0)
                return true;
            var result = 0;
            foreach (var x in nums)
            {
                result = result ^ x;
            }
            return result == 0;
        }
    }
}
