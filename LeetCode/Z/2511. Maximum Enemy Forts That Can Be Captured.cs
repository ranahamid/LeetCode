using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2511
    {
        #region self
        public int CaptureForts(int[] forts)
        { 
            int one = -1;
            int minus = -1;
            int last = 0;
            int tempLast = 0;

            int max = 0;
            int current = 0;
            for (int i = 0; i < forts.Length; i++)
            {
                if (forts[i] == 0)
                    current++;
                else
                {
                    if (forts[i] == 1)
                    {
                        one = i;
                        tempLast = 1;
                    }
                    if (forts[i] == -1)
                    {
                        minus = i;
                        tempLast = -1;
                    }
                    if (one >= 0 && minus >= 0 && last != forts[i])
                    {
                        max = Math.Max(max, Math.Abs(one - minus) - 1);
                    }
                    current = 0;
                    var temp = Math.Max(one, minus);
                    if (one >= 0)
                        one = temp;
                    if (minus >= 0)
                        minus = temp;
                    last = tempLast;
                }
            }
            return max;
        }
        #endregion
        public int CaptureForts_1(int[] forts)
        {
            int ans = 0;
            int j = 0;
            for (int i = 0; i < forts.Length; i++)
            {
                if (forts[i] != 0)
                {
                    if (forts[i] == forts[j] * -1)
                    {
                        ans = Math.Max(ans, i - j - 1);
                    }
                    j = i;
                }
            }
            return ans;
        }
    }
}
