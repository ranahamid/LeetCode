using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _717
    {
        /// <summary>
        /// Runtime: 106 ms, faster than 95.45% of C# online submissions for 1-bit and 2-bit Characters.
        /// Memory Usage: 39.3 MB, less than 81.82% of C# online submissions for 1-bit and 2-bit Characters.
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public bool IsOneBitCharacter(int[] bits)
        {

            var prev = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                prev = i;
                if (bits[i] == 1)
                    i++;
            }
            return prev == bits.Length - 1;
        }
    }
}
