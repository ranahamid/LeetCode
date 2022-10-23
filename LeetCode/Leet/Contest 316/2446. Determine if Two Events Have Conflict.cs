using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_316
{
    internal class _2446
    {
        /// <summary>
        /// Runtime 166 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 39.8 MB Beats 100%
        /// </summary>
        /// <param name="event1"></param>
        /// <param name="event2"></param>
        /// <returns></returns>
        public bool HaveConflict(string[] event1, string[] event2)
        {
            var day = new bool[1440];
            var start1 = GetTime(event1[0]);
            var end1 = GetTime(event1[1]);
            for (int i = start1; i <= end1; i++)
                day[i] = true;

            start1 = GetTime(event2[0]);
            end1 = GetTime(event2[1]);
            for (int i = start1; i <= end1; i++)
            {
                if (day[i] == true)
                    return true;
                day[i] = true;
            }

            return false;
        }
        public int GetTime(string s)
        {
            var hour = s[0].ToString() + s[1].ToString();
            var min = s[3].ToString() + s[4].ToString();
            var h = Int32.Parse(hour);
            var m = Int32.Parse(min);
            return h * 60 + m;
        }
    }
}
