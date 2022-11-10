using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _693
    {

        /// <summary>
        /// Runtime: 43 ms, faster than 81.40% of C# online submissions for Binary Number with Alternating Bits.
        /// Memory Usage: 26.7 MB, less than 76.74% of C# online submissions for Binary Number with Alternating Bits.
        /// Bitwise
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool HasAlternatingBits(int n)
        {
            var temp = -1;
            while (n > 0)
            {
                var val = n & 1;
                if (val == temp)
                    return false;
                temp = val;
                n >>= 1;
            }
            return true;
        }


        /// <summary>
        /// Runtime: 42 ms, faster than 83.72% of C# online submissions for Binary Number with Alternating Bits.
        /// Memory Usage: 27.1 MB, less than 37.21% of C# online submissions for Binary Number with Alternating Bits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool HasAlternatingBits_2(int n)
        {
            string s = Convert.ToString(n, 2);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                    return false;
            }
            return true;
        }

    }
}
