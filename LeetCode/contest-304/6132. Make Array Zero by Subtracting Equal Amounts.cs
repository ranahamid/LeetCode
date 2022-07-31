using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_304
{
    internal class _6132
    {
        public int MinimumOperations(int[] nums)
        {
            return new HashSet<int>(nums.Where(x => x != 0)).Count();
        }
    }
}
