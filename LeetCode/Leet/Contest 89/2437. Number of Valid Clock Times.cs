using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_89
{
    internal class _2437
    {
        /// <summary>
        /// Runtime 87 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 34.3 MB Beats 100%
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int CountTime(string time)
        {
            var total = 0;
            if (time[1] == '?')
            {
                if (time[0] == '?')
                {
                    total = 24;
                }
                else
                {
                    if (time[0] >= '0' && time[0] <= '1')
                        total = 10;
                    else
                        total = 4;
                }
            }
            else
            {
                if (time[0] == '?')
                {
                    if (time[1] >= '0' && time[1] <= '3')
                        total = 3;
                    else
                        total = 2;
                }
            }
            if (total == 0)
                total = 1;
            var sum = 0;
            if (time[3] == '?')
            {
                if (time[4] == '?')
                {
                    sum = 60;
                }
                else
                {
                    sum = 6;
                }
            }
            else
            {
                if (time[4] == '?')
                {
                    sum = 10;
                }
            }
            if (sum == 0)
                sum = 1;
            return total * sum;
        }
    }
}
