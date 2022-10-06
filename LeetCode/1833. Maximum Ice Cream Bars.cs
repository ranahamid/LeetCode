using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1833
    {
        /// <summary>
        /// Runtime 480 ms Beats 60.46% Memory 50.2 MB Beats 62.79%
        /// </summary>
        /// <param name="costs"></param>
        /// <param name="coins"></param>
        /// <returns></returns>
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            int counter = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                if (coins >= costs[i])
                {
                    counter++;
                    coins -= costs[i];
                }
                else
                    break;
            }
            return counter;
        }
    }
}
