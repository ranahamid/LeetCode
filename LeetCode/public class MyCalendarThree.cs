using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 519 ms, faster than 63.16% of C# online submissions for My Calendar III.
    /// Memory Usage: 43.8 MB, less than 68.42% of C# online submissions for My Calendar III.
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
