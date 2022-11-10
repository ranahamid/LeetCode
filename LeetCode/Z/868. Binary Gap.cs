using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _868
    {
        /// <summary>
        /// Runtime: 38 ms, faster than 30.56% of C# online submissions for Binary Gap.
        /// Memory Usage: 25.1 MB, less than 88.89% of C# online submissions for Binary Gap.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int BinaryGap(int n)
        {
            var binary = Convert.ToString(n, 2);
            var max = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    var val = GetAdjacentPair(i, binary);
                    max = Math.Max(max, val);
                }
            }
            return max;
        }
        public static int GetAdjacentPair(int startIndex, string binary)
        {
            var count = 1;
            for (int i = startIndex + 1; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    count++;
                }
                else
                {
                    return count;
                }
            }
            return 0;
        }

    }
}
