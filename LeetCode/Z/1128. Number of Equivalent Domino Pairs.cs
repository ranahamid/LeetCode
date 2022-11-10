using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1128
    {
        /// <summary>
        /// Runtime: 157 ms, faster than 82.89% of C# online submissions for Number of Equivalent Domino Pairs.
        /// Memory Usage: 43.6 MB, less than 89.47% of C# online submissions for Number of Equivalent Domino Pairs.
        /// </summary>
        /// <param name="dominoes"></param>
        /// <returns></returns>
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < dominoes.Length; i++)
            {
                var num = Math.Min(dominoes[i][0], dominoes[i][1]) * 10 + Math.Max(dominoes[i][0], dominoes[i][1]);
                dic.TryAdd(num, 0);
                dic[num]++;
            }
            var counter = 0;
            foreach (var n in dic.Values)
            {

                counter += n * (n - 1) / 2;
            }
            return counter;
        }
        #region TLE
        public int NumEquivDominoPairs_TLE(int[][] dominoes)
        {
            var counter = 0;
            for (int i = 0; i < dominoes.Length; i++)
            {
                for (int j = i + 1; j < dominoes.Length; j++)
                {
                    if (dominoes[i][0] == dominoes[j][0] && dominoes[i][1] == dominoes[j][1] ||
                        dominoes[i][0] == dominoes[j][1] && dominoes[i][1] == dominoes[j][0])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        #endregion
    }
}
