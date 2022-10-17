using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1759
    {
        /// <summary>
        /// Runtime 90 ms Beats 77.78% Memory 40.6 MB Beats 16.67
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountHomogenous(string s)
        {
            int result = 0, current = 0, counter = 0;
            var mod = (int)(Math.Pow(10, 9) + 7);
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == current)
                    counter++;
                else
                    counter = 1;
                current = s[i];
                result = (result + counter) % mod;
            }
            return result;
        }
    }
}
