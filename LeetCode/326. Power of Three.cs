using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _326
    {

        /// <summary>
        /// https://stackoverflow.com/questions/1804311/how-to-check-if-an-integer-is-a-power-of-3
        /// Runtime: 104 ms, faster than 35.47% of C# online submissions for Power of Three.
        /// Memory Usage: 29 MB, less than 43.02% of C# online submissions for Power of Three.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfThree(int n)
        {
            //not so good
            var div = Math.Round((Math.Log(n) / Math.Log(3)), 10);
            return div - (int)div == 0;

        }

        /// <summary>
        /// Runtime: 48 ms, faster than 98.32% of C# online submissions for Power of Three.
        /// Memory Usage: 29.5 MB, less than 26.26% of C# online submissions for Power of Three.
        /// Because 3^19 = 1162261467 is the largest power of 3 number fits in a 32 bit integer, thus we can do
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfThree_3(int n)
        {
            return n > 0 && 1162261467 % n == 0;
        }

        /// <summary>
        /// https://stackoverflow.com/questions/1804311/how-to-check-if-an-integer-is-a-power-of-3
        /// Runtime: 104 ms, faster than 35.47% of C# online submissions for Power of Three.
        /// Memory Usage: 29 MB, less than 43.02% of C# online submissions for Power of Three.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfThree_1(int n)
        {
            // Optimizing lines to handle the most common cases extremely quickly
            if (n % 3 != 0) return n == 1;
            if (n % 9 != 0) return n == 3;

            // General algorithm - works for any uint
            int r;
            n = Math.DivRem(n, 59049, out r); if (n != 0 && r != 0) return false;
            n = Math.DivRem(n + r, 243, out r); if (n != 0 && r != 0) return false;
            n = Math.DivRem(n + r, 27, out r); if (n != 0 && r != 0) return false;
            n += r;
            return n == 1 || n == 3 || n == 9;

        }
        /// <summary>
        /// With using loops, which is not accepted
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfThree_2(int n)
        {
            if (n == 0)
                return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }



    }
}
