using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _836
    {
        /// <summary>
        /// Runtime 141 ms Beats 66.67% Memory 38.3 MB Beats 87.50%
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {

            if (rec1[0] >= rec2[2] || rec1[1] >= rec2[3] ||
                rec2[0] >= rec1[2] || rec2[1] >= rec1[3])
                return false;
            return true;
        }
    }
}
