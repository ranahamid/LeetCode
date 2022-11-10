using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1143
    {
        #region interview 
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var dp = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 0; i < text1.Length + 1; i++)
                for (int j = 0; j < text2.Length + 1; j++)
                    dp[i, j] = -1;
            return LCS(text1, text2, dp, 0, 0);
        }
        public static int LCS(string text1, string text2, int[,] dp, int i, int j)
        {
            if (i >= text1.Length || j >= text2.Length)
                return 0;
            if (dp[i, j] != -1)
                return dp[i, j];
            int result = 0;
            if (text1[i] == text2[j])
                result = 1 + LCS(text1, text2, dp, i + 1, j + 1);
            else
                result = Math.Max(LCS(text1, text2, dp, i + 1, j), LCS(text1, text2, dp, i, j + 1));
            return dp[i, j] = result;
        }
        #endregion
        /// <summary>
        /// Runtime 107 ms Beats 66.74% Memory 40.5 MB Beats 17.65%
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        public int LongestCommonSubsequence_1(string text1, string text2)
        {
            var dp = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 0; i < text1.Length + 1; i++)
                for (int j = 0; j < text2.Length; j++)
                    dp[i, j] = -1;
            return LCS_1(text1, text2, dp, 0, 0);
        }
        public int LCS_1(string text1, string text2, int[,] dp, int i, int j)
        {
            if (i >= text1.Length || j >= text2.Length)
                return 0;
            if (dp[i, j] != -1)
                return dp[i, j];

            int result = 0;
            if (text1[i] == text2[j])
                result = 1 + LCS_1(text1, text2, dp, i + 1, j + 1);
            else
                result = Math.Max(LCS_1(text1, text2, dp, i + 1, j), LCS_1(text1, text2, dp, i, j + 1));
            dp[i, j] = result;
            return dp[i, j];

        }
    }
}
