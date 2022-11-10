using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _492
    {
        /// <summary>
        /// Runtime: 157 ms, faster than 50.00% of C# online submissions for Construct the Rectangle.
        /// Memory Usage: 34.2 MB, less than 100.00% of C# online submissions for Construct the Rectangle.
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public static int[] ConstructRectangle(int area)
        {
            var sqrtVal = (int)Math.Sqrt(area);
            for (int i = sqrtVal; i >= 1; i--)
            {
                if (area % i == 0)
                {
                    return new int[] { area / i, i };
                }
            }
            return new int[] { area, 1 };
        }
    }
}
