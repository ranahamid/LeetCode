using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_87
{
    internal class _2409
    {
        /// <summary>
        /// Runtime: 118 ms, faster than 100.00% of C# online submissions for Count Days Spent Together.
        /// Memory Usage: 36.4 MB, less than 100.00% of C# online submissions for Count Days Spent Together.
        /// </summary>
        /// <param name="arriveAlice"></param>
        /// <param name="leaveAlice"></param>
        /// <param name="arriveBob"></param>
        /// <param name="leaveBob"></param>
        /// <returns></returns>
        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            DateTime arrive2 = DateTime.Parse(arriveBob + "-2019");
            DateTime leave2 = DateTime.Parse(leaveBob + "-2019");
            DateTime arrive1 = DateTime.Parse(arriveAlice + "-2019");
            DateTime leave1 = DateTime.Parse(leaveAlice + "-2019");
            var count = 0;
            for (DateTime i = arrive1; i <= leave1; i = i.AddDays(1))
            {
                if (i >= arrive2 && i <= leave2)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
