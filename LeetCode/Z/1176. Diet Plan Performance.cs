using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode.Z
{
    internal class _1176
    {
        /// <summary>
        /// Runtime: 230 ms, faster than 48.28% of C# online submissions for Diet Plan Performance.
        ///  Memory Usage: 41.6 MB, less than 100.00% of C# online submissions for Diet Plan Performance.

        /// </summary>
        /// <param name="calories"></param>
        /// <param name="k"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            long total = 0;
            var score = 0;
            for (int i = 0; i < calories.Length; i++)
            {
                total += calories[i];
                if (i >= k - 1)
                {
                    if (i >= k)
                        total -= calories[i - k];

                    if (total < lower)
                        score--;
                    else if (total > upper)
                        score++;
                }
            }
            return score;
        }

        ///Brute Force
        /// <summary>
        /// Runtime: 2536 ms, faster than 13.79% of C# online submissions for Diet Plan Performance.
        /// Memory Usage: 41.7 MB, less than 100.00% of C# online submissions for Diet Plan Performance.
        /// </summary>
        /// <param name="calories"></param>
        /// <param name="k"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public int DietPlanPerformance_Brute(int[] calories, int k, int lower, int upper)
        {
            long total = 0;
            var score = 0;
            for (int i = 0; i < calories.Length - k + 1; i++)
            {
                total = 0;
                for (int j = i; j < i + k; j++)
                {
                    total += calories[j];
                }
                if (total < lower)
                    score--;
                else if (total > upper)
                    score++;
            }
            return score;
        }
    }
}
