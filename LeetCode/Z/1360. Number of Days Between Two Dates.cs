using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1360
    {
        /// <summary>
        /// Runtime: 80 ms, faster than 83.56% of C# online submissions for Number of Days Between Two Dates.
        /// Memory Usage: 35 MB, less than 97.26% of C# online submissions for Number of Days Between Two Dates.
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public int DaysBetweenDates(string date1, string date2)
        {
            var s = date1.Split("-");
            DateTime a = new DateTime(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
            s = date2.Split("-");
            DateTime b = new DateTime(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
            var totalDays = (b - a).TotalDays;
            return Math.Abs((int)totalDays);
        }
    }
}
