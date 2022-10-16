﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1335
    {
        /// <summary>
        /// Runtime 175 ms Beats 53.49% Memory 37.3 MB Beats 67.44%
        /// </summary>
        /// <param name="jobDifficulty"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            var dp = new int[d + 1, jobDifficulty.Length + 1];
            for (int i = 0; i <= d; i++)
                for (int j = 0; j < jobDifficulty.Length; j++)
                    dp[i, j] = Int32.MaxValue;

            for (int days = 1; days <= d; days++)
                for (int i = 0; i < jobDifficulty.Length - days + 1; i++)
                {
                    var difficult = 0;
                    for (int j = i + 1; j < jobDifficulty.Length - days + 2; j++)
                    {
                        difficult = Math.Max(difficult, jobDifficulty[j - 1]);
                        if (dp[days - 1, j] != Int32.MaxValue)
                        {
                            var current = difficult + dp[days - 1, j];
                            dp[days, i] = Math.Min(dp[days, i], current);
                        }
                    }
                }
            return dp[d, 0] < Int32.MaxValue ? dp[d, 0] : -1;
        }
    }
}
