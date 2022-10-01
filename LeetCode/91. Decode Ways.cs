using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _91
    {
        /// <summary>
        /// Runtime 62 ms
        ///Beats 98.46%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int NumDecodings(string s)
        {
            var dp = new int[s.Length + 1];
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;
            for (int i = 2; i < dp.Length; i++)
            {
                if (s[i - 1] != '0')
                    dp[i] = dp[i - 1];
                var nmb = s[i - 2].ToString() + s[i - 1].ToString();
                var number = int.Parse(nmb);
                if (number >= 10 && number <= 26)
                    dp[i] += dp[i - 2];
            }
            return dp[s.Length];
        }
    }
}
