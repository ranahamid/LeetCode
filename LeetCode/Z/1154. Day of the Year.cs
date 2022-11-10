using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1154
    {
        /// <summary>
        /// Runtime: 141 ms, faster than 62.22% of C# online submissions for Day of the Year.
        /// Memory Usage: 37.3 MB, less than 51.11% of C# online submissions for Day of the Year.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int DayOfYear(string date)
        {
            var words = date.Split('-');
            var year = int.Parse(words[0]);
            var month = int.Parse(words[1]);
            var dateN = int.Parse(words[2]);

            var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            var isLeapYear = false;
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                isLeapYear = true;
            }
            var totalDays = dateN;
            for (int i = 1; i < month; i++)//month=2
            {
                totalDays += days[i - 1];
            }
            if (isLeapYear)
            {
                if (month > 2)
                {
                    totalDays++;
                }
            }

            return totalDays;
        }
    }
}
