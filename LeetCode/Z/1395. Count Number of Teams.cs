using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1395
    {
        /// <summary>
        /// Runtime 122 ms Beats 92.50% Memory 38.7 MB Beats 42.50%
        /// </summary>
        /// <param name="rating"></param>
        /// <returns></returns>
        public int NumTeams(int[] rating)
        {
            int counter = 0;
            var len = rating.Length;
            int[] dp = new int[len];
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (rating[i] > rating[j])
                    {
                        dp[i]++;
                        counter += dp[j];
                    }
                }
            }
            dp = new int[len];
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (rating[i] < rating[j])
                    {
                        dp[i]++;
                        counter += dp[j];
                    }
                }
            }
            return counter;
        }
        #region TLE
        public int NumTeams_TLE(int[] rating)
        {
            int counter = 0;
            var len = rating.Length;
            for (int i = 0; i < len - 2; i++)
            {
                for (int j = i + 1; j < len - 1; j++)
                {
                    for (int k = j + 1; k < len; k++)
                    {
                        if (rating[i] < rating[j] && rating[j] < rating[k] || rating[i] > rating[j] && rating[j] > rating[k])
                            counter++;
                    }
                }
            }
            return counter;
        }
        #endregion
    }
}
