using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1010
    {
        /// <summary>
        /// Runtime 130 ms Beats 94.17% Memory 48.8 MB Beats 11.65%
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int NumPairsDivisibleBy60(int[] time)
        {
            var reminder = new int[60];
            var counter = 0;
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] % 60 == 0)
                    counter += reminder[0];
                else
                    counter += reminder[60 - time[i] % 60];

                reminder[time[i] % 60]++;
            }
            return counter;
        }
        #region brute force 
        public int NumPairsDivisibleBy60_Brute(int[] time)
        {
            var counter = 0;
            for (int i = 0; i < time.Length; i++)
            {
                for (int j = i + 1; j < time.Length; j++)
                {

                    if ((time[i] + time[j]) % 60 == 0)
                        counter++;
                }
            }
            return counter;
        }
        #endregion
    }
}
