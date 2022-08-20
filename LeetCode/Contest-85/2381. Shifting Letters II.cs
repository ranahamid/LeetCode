using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_85
{
    internal class _2381
    {
        #region TLE
        public string ShiftingLetters_TLE(string s, int[][] shifts)
        {

            var forward = new int[s.Length];
            var backward = new int[s.Length];
            for (int i = 0; i < shifts.Length; i++)
            {
                for (int j = shifts[i][0]; j <= shifts[i][1]; j++)
                {
                    if (shifts[i][2] == 1)
                    {
                        forward[j] = (forward[j] + 1) % 26;
                    }
                    else
                    {
                        backward[j] = (backward[j] + 1) % 26;
                    }
                }
            }
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < forward.Length; i++)
            {
                if (forward[i] >= backward[i])
                {
                    forward[i] -= backward[i];
                    if (forward[i] > 0)
                    {
                        var replaceChar = (sb[i] - 97 + forward[i] + 26 * 100) % 26;
                        sb[i] = (char)(replaceChar + 97);
                    }
                }
                else
                {
                    backward[i] -= forward[i];
                    if (backward[i] > 0)
                    {
                        var replaceChar = (sb[i] - 97 - backward[i] + 26 * 100) % 26;
                        sb[i] = (char)(replaceChar + 97);
                    }
                }
            }
            return sb.ToString();
        }
        #endregion
    }
}
