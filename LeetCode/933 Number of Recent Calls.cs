using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /// <summary>
    /// Runtime: 2135 ms, faster than 5.71% of C# online submissions for Number of Recent Calls.
    /// Memory Usage: 57.2 MB, less than 68.57% of C# online submissions for Number of Recent Calls.
    /// </summary>
    public class RecentCounter
    {
        List<int> list;
        public RecentCounter()
        {
            list = new List<int>();
        }

        public int Ping(int t)
        {
            list.Add(t);
            var first = t - 3000 < 0 ? 0 : t - 3000;
            var count = list.Where(x => x >= first && x <= t).Count();
            return count;
        }
    }
}
