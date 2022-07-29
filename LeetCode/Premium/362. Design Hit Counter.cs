using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    /// <summary>
    /// Runtime: 146 ms, faster than 52.21% of C# online submissions for Design Hit Counter.
    /// Memory Usage: 38.2 MB, less than 19.85% of C# online submissions for Design Hit Counter.
    /// </summary>
    public class HitCounter
    {
        private Dictionary<int, int> hitSet;
        public HitCounter()
        {
            hitSet = new Dictionary<int, int>();
        }

        public void Hit(int timestamp)
        {
            if (hitSet.ContainsKey(timestamp))
            {
                hitSet[timestamp]++;
            }
            else
            {
                hitSet[timestamp] = 1;
            }
        }

        public int GetHits(int timestamp)
        {
            var counterVal = hitSet.Where(x => x.Key <= timestamp && x.Key >= timestamp - 299).Select(x => x.Value);
            return counterVal.Sum();
        }
    }

}
