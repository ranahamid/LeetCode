using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _836
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            if (rec1[0] >= rec2[2] || rec1[1] >= rec2[3] ||
            rec2[0] >= rec1[2] || rec2[1] >= rec1[3])
                return false;
            return true;
        }
    }
}
