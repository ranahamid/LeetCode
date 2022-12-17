using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2498
    {
        /// <summary>
        /// Runtime 238 ms Beats 75.56% Memory 53.1 MB Beats 48.89%
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        public int MaxJump(int[] stones)
        {
            var res = stones[1] - stones[0];
            for (int i = 2; i < stones.Length; i++)
            {
                var temp = stones[i] - stones[i - 2];
                res = Math.Max(res, temp);
            }
            return res;
        }
    }
}
