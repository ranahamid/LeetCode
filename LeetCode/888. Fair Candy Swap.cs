using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _888
    {
        /// <summary>
        /// Runtime: 293 ms, faster than 77.27% of C# online submissions for Fair Candy Swap.
        /// Memory Usage: 48.2 MB, less than 84.09% of C# online submissions for Fair Candy Swap.
        /// </summary>
        /// <param name="aliceSizes"></param>
        /// <param name="bobSizes"></param>
        /// <returns></returns>
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            var sA = aliceSizes.Sum();
            var sB = bobSizes.Sum();

            var sAsB = (sB - sA) / 2;
            HashSet<int> set = new HashSet<int>(bobSizes);
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                if (set.Contains(aliceSizes[i] + sAsB))
                {
                    return new int[] { aliceSizes[i], aliceSizes[i] + sAsB };
                }
            }
            return new int[] { };
        }
    }
}
