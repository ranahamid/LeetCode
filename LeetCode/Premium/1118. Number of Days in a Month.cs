using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1118
    {

        /// <summary>
        /// Runtime: 38 ms, faster than 50.00% of C# online submissions for Number of Days in a Month.
        /// Memory Usage: 25.3 MB, less than 50.00% of C# online submissions for Number of Days in a Month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static int NumberOfDays(int year, int month)
        {
            var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month != 2)
            {
                return days[month - 1];
            }

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {

                return 29;
            }
            else
                return 28;
        }

        /// <summary>
        /// Runtime: 33 ms, faster than 50.00% of C# online submissions for Number of Days in a Month.
        /// Memory Usage: 25.2 MB, less than 100.00% of C# online submissions for Number of Days in a Month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static int NumberOfDays_1(int year, int month)
        {
            var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month != 2)
            {
                return days[month - 1];
            }

            if (year % 4 == 0 && year % 100 == 0)
            {
                if (year % 400 == 0)
                    return 29;
                else
                    return 28;
            }
            if (year % 4 == 0)
            {
                return 29;
            }

            return 28;
        }

    }
}
