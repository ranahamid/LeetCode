using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _858
    {
        public int MirrorReflection(int p, int q)
        {
            while (p % 2 == 0 && q % 2 == 0)
            {
                p >>= 1;
                q >>= 1;
            }
            if (p % 2 == 0 && q % 2 == 1)
                return 2;
            if (p % 2 == 1 && q % 2 == 1)
                return 1;
            return 0;
        }
        /// <summary>
        /// Runtime: 35 ms, faster than 77.78% of C# online submissions for Mirror Reflection.
        /// Memory Usage: 25.2 MB, less than 11.11% of C# online submissions for Mirror Reflection.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public int MirrorReflection_1(int p, int q)
        {
            while (p % 2 != 1 && q % 2 != 1)
            {
                p = p / 2;
                q = q / 2;
            }
            if (p % 2 == 0 && q % 2 == 1)
                return 2;
            if (p % 2 == 1 && q % 2 == 1)
                return 1;
            return 0;
        }
    }
}
