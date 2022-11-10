using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1423_Maximum_Points_You_Can_Obtain_from_Cards
    {
        /// <summary>
        /// Runtime: 206 ms, faster than 48.15% of C# online submissions for Maximum Points You Can Obtain from Cards.
        /// Memory Usage: 44.7 MB, less than 53.70% of C# online submissions for Maximum Points You Can Obtain from Cards.
        /// </summary>
        /// <param name="cardPoints"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxScore(int[] cardPoints, int k)
        {

            int len = cardPoints.Length;
            int currentSum = cardPoints.Take(k).Sum();
            var maxSum = currentSum;
            for (int i = 1; i <= k; i++)
            {
                currentSum = currentSum - cardPoints[k - i];
                currentSum = currentSum + cardPoints[len - i];
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }


    }
}
