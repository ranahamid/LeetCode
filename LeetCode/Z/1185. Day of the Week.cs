using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1185
    {
        /// <summary>
        /// https://www.hackerearth.com/blog/developers/how-to-find-the-day-of-a-week/
        /// Runtime: 112 ms, faster than 30.34% of C# online submissions for Day of the Week.
        /// Memory Usage: 35 MB, less than 98.88% of C# online submissions for Day of the Week.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string DayOfTheWeek(int day, int month, int year)
        {
            var resW2 = new string[]
            {
              "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };
            var t = new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (month < 3)
                year--;

            var data = (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;
            return resW2[data];

        }

        /// <summary>
        /// Built-in
        /// Runtime: 119 ms, faster than 20.22% of C# online submissions for Day of the Week.
        /// Memory Usage: 35.3 MB, less than 91.01% of C# online submissions for Day of the Week.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string DayOfTheWeek_2(int day, int month, int year)
        {
            var date = new DateTime(year, month, day);
            var weekDay = date.DayOfWeek;
            return weekDay.ToString();
        }

    }
}
