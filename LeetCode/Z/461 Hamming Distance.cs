using System;
using System.Linq;

namespace LeetCode.Z
{
    public class _461_Hamming_Distance
    {

        /// <summary>
        /// Runtime: 28 ms, faster than 70.72% of C# online submissions for Hamming Distance.
        /// Memory Usage: 26.1 MB, less than 19.89% of C# online submissions for Hamming Distance.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int HammingDistance_2(int x, int y)
        {
            var n = x ^ y;
            var count = 0;
            while (n > 0)
            {
                count = count + (n & 1);
                n = n >> 1;
            }
            return count;
        }
        /// <summary>
        /// Runtime: 29 ms, faster than 69.06% of C# online submissions for Hamming Distance.
        /// Memory Usage: 26.1 MB, less than 19.89% of C# online submissions for Hamming Distance.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int HammingDistance(int x, int y)
        {
            var n = x ^ y;
            var binary = Convert.ToString(n, 2).ToCharArray();
            return binary != null ? binary.Where(z => z == '1').Count() : 0;
        }
    }
}