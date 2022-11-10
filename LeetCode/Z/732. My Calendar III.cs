using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime: 385 ms, faster than 73.68% of C# online submissions for My Calendar III.
    /// Memory Usage: 52.1 MB, less than 15.79% of C# online submissions for My Calendar III.
    /// </summary>
    public class MyCalendarThree
    {
        private SortedDictionary<int, int> books;
        public MyCalendarThree()
        {
            books = new SortedDictionary<int, int>();
        }

        public int Book(int start, int end)
        {
            if (!books.ContainsKey(start))
                books.Add(start, 0);
            books[start]++;
            if (!books.ContainsKey(end))
            {
                books.Add(end, 0);
            }
            books[end]--;
            int sum = 0;
            var max = 1;
            foreach (var item in books)
            {
                sum += item.Value;
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
