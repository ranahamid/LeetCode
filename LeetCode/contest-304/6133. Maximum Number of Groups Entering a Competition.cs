using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_304
{
    internal class _6133
    {
        public int MaximumGroups(int[] grades)
        {
            var length = grades.Length;
            for (int i = 1; i <= Int32.MaxValue; i++)
            {
                long total = i * (i + 1) / 2;
                if (total == length)
                    return i;
                if (total > length)
                    return i - 1;
            }
            return 0;
        }

    }
}
