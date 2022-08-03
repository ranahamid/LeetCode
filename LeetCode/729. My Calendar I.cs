using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 356 ms, faster than 70.75% of C# online submissions for My Calendar I.
    /// Memory Usage: 46.9 MB, less than 73.40% of C# online submissions for My Calendar I.
    /// </summary>
    public class MyCalendar
    {
        public List<(int start, int end)> calendar;
        public MyCalendar()
        {
            calendar = new List<(int start, int end)>();
        }

        public bool Book(int start, int end)
        {
            foreach (var item in calendar)
            {
                if (end > item.start && item.end > start) //[[], [10, 20], [15, 25], [20, 30]]
                    return false;

            }
            calendar.Add((start, end));
            return true;
        }
    }
}
