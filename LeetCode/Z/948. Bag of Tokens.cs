using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _948
    {
        /// <summary>
        /// Runtime: 75 ms, faster than 100.00% of C# online submissions for Bag of Tokens.
        /// Memory Usage: 39.4 MB, less than 11.11% of C# online submissions for Bag of Tokens.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public int BagOfTokensScore(int[] tokens, int power)
        {
            Array.Sort(tokens);
            int maxScore = 0, CurrentScore = 0;
            int low = 0, high = tokens.Length - 1;
            while (low <= high && (power >= tokens[low] || CurrentScore > 0))
            {
                while (low <= high && power >= tokens[low])
                {
                    power -= tokens[low];
                    low++;
                    CurrentScore++;
                }
                maxScore = Math.Max(maxScore, CurrentScore);
                if (low <= high && CurrentScore > 0)
                {
                    power += tokens[high];
                    high--;
                    CurrentScore--;
                }
            }
            return maxScore;
        }
    }
}
