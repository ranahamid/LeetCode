using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3516
    {
        public int FindClosest(int x, int y, int z)
        {
            var aDiff = Math.Abs(z - x);
            var bDiff = Math.Abs(z - y);
            if (aDiff < bDiff)
            {
                return 1;
            }
            else if (bDiff < aDiff)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
