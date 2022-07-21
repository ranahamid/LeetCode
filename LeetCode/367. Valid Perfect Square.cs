using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _367
    {
        public static bool IsPerfectSquare(int num)
        {
            int i = 1;
            for (; ; )
            {
                if (num < 0)
                    return false;
                if (num == 0)
                    return true;
                num = num - i;
                i += 2;
            }
        }
    }
}
