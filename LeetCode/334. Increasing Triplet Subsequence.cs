using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _334
    {
        /// <summary>
        /// Runtime 244 ms Beats 77.46% Memory 48.3 MB Beats 87.64%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool IncreasingTriplet(int[] nums)
        {
            int min1 = Int32.MaxValue, min2 = Int32.MaxValue;
            foreach (var item in nums)
            {
                if (item <= min1)
                {
                    min1 = item;
                }
                else if (item <= min2)
                {
                    min2 = item;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
