using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1891
    {
        /// <summary>
        /// Runtime 414 ms Beats 79.41% Memory 50.5 MB Beats 41.18%
        /// </summary>
        /// <param name="ribbons"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaxLength(int[] ribbons, int k)
        {
            int high = ribbons.Max() + 1;
            var low = 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (IsValid(ribbons, mid, k))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low - 1;
        }

        bool IsValid(int[] ribbons, int mid, int k)
        {
            int count = 0;
            for (int i = 0; i < ribbons.Length; i++)
            {
                count += ribbons[i] / mid;
            }
            return count >= k;
        }
    }
}
