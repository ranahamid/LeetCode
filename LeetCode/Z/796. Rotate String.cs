using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _796
    {
        /// <summary>
        /// Runtime: 120 ms, faster than 29.44% of C# online submissions for Rotate String.
        /// Memory Usage: 36.4 MB, less than 80.37% of C# online submissions for Rotate String.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="goal"></param>
        /// <returns></returns>
        public bool RotateString(string s, string goal)
        {
            return (s + s).Contains(goal) && s.Count() == goal.Count();
        }
    }
}
