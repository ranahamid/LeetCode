using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Week_1
{
    internal class Time_Conversion
    {
        public static string timeConversion(string s)
        {
            var d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }
    }
}
