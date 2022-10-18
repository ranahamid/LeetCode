using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _38
    {
        /// <summary>
        /// Runtime 1520 ms Beats 5.3% Memory 37.4 MB Beats 64.78%
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string CountAndSay(int n)
        {
            var current = "1";
            for (int i = 2; i <= n; i++)
            {
                int j = 0, k = 0;
                var next = "";
                while (j < current.Count())
                {

                    while (k < current.Count() && current[j] == current[k])
                    {
                        k++;
                    }
                    next += (k - j).ToString() + current[j];
                    j = k;
                }
                current = next;
            }
            return current;
        }
    }
}
