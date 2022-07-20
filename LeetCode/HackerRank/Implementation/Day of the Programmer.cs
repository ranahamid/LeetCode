using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Day_of_the_Programmer
    {
        public static string dayOfProgrammer(int year)
        {
            if (year == 1918)
                return "26.09.1918";
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) || year == 1800 || year == 1900 || year == 1700)
            {
                return String.Format("12.09.{0}", year);
            }
            return String.Format("13.09.{0}", year);
        }
    }
}
