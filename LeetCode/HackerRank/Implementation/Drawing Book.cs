using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Drawing_Book
    {
        public static int pageCount(int n, int p)
        {
            var a = ((p - 1) + 1) / 2;
            var b = (n - p) / 2;

            var min = Math.Min(a, b);
            if (min == 0 && n != p)
            {
                if (n % 2 == 0 && n > 2)
                    min++;
            }
            return min;
        }
    }
}
