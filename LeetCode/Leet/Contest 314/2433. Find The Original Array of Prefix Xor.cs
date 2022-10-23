using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_314
{
    internal class _2433
    {
        /// <summary>
        /// Runtime 568 ms Beats 100% 
        /// </summary>
        /// <param name="pref"></param>
        /// <returns></returns>
        public int[] FindArray(int[] pref)
        {
            var result = new int[pref.Length];
            for (int i = 0; i < pref.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = pref[i];
                }
                else
                {
                    result[i] = pref[i] ^ pref[i - 1];
                }
            }
            return result;
        }
    }
}
