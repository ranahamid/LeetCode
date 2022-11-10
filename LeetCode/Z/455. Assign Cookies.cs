using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _455
    {
        /// <summary>
        /// Runtime 201 ms Beats 47.20% Memory 41.7 MB Beats 83.20%
        /// </summary>
        /// <param name="g"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int counter = 0;

            foreach (var item in s)
            {
                if (counter >= g.Length)
                    break;
                if (g[counter] <= item)
                    counter++;
            }
            return counter;
        }
    }
}
