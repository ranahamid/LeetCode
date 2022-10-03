using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1578
    {
        #region one pass 
        /// <summary>
        /// Runtime 332 ms Beats 77.67% Memory 47.8 MB Beats 75.73%
        /// </summary>
        /// <param name="colors"></param>
        /// <param name="neededTime"></param>
        /// <returns></returns>
        public int MinCost(string colors, int[] neededTime)
        {
            int totalTime = 0, currentMax = 0;
            for (int i = 0; i < neededTime.Length; i++)
            {
                if (i > 0 && colors[i] != colors[i - 1])
                    currentMax = 0;
                totalTime += Math.Min(currentMax, neededTime[i]);
                currentMax = Math.Max(currentMax, neededTime[i]);
            }
            return totalTime;
        }
        #endregion
        #region two pass
        /// <summary>
        /// Runtime 375 ms Beats 69.90% Memory 47.4 MB Beats 84.47%
        /// </summary>
        /// <param name="colors"></param>
        /// <param name="neededTime"></param>
        /// <returns></returns>
        public int MinCost_2(string colors, int[] neededTime)
        {
            int totalTime = 0;
            int left = 0, right = 0;
            var totalLength = neededTime.Length;
            while (left < totalLength && right < totalLength)
            {
                int currentMax = 0, currentTotal = 0;
                while (right < totalLength && colors[left] == colors[right])
                {
                    currentTotal += neededTime[right];
                    if (neededTime[right] > currentMax)
                        currentMax = neededTime[right];
                    right++;
                }
                totalTime += currentTotal - currentMax;
                left = right;
            }
            return totalTime;
        }
        #endregion
    }
}
