using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_85
{
    internal class _2379
    {
        public int MinimumRecolors(string blocks, int k)
        {
            var min = Int32.MaxValue;
            for (int i = 0; i <= blocks.Length - k; i++)
            {
                var word = blocks.Substring(i, k);
                var length = word.Count(x => x == 'W');
                min = Math.Min(min, length);
            }
            return min;
        }
      
    }
}
