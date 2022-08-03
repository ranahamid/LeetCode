using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 216 ms, faster than 100.00% of C# online submissions for My Calendar II.
    /// Memory Usage: 59.3 MB, less than 6.82% of C# online submissions for My Calendar II.
    /// </summary>
    public class MyCalendarTwo
    {
        public List<(int start, int end)> overlaps;
        public List<(int start, int end)> calendar;
        public MyCalendarTwo()
        {
            calendar = new List<(int start, int end)>();
            overlaps = new List<(int start, int end)>();
        }

        public bool Book(int start, int end)
        {
            foreach (var item in overlaps)
            {
                if (end > item.start && item.end > start)
                {
                    return false;
                }
            }
            foreach (var item in calendar)
            {
                if (end > item.start && item.end > start)
                {
                    overlaps.Add((Math.Max(item.start, start), Math.Min(item.end, end)));
                }
            }
            calendar.Add((start, end));
            return true;
        }
    }
}

