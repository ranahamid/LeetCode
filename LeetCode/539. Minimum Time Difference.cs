using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _539
    {
        /// <summary>
        /// Runtime 103 ms Beats 93.26% Memory 44.1 MB Beats 15.73%
        /// </summary>
        /// <param name="timePoints"></param>
        /// <returns></returns>
        public int FindMinDifference(IList<string> timePoints)
        {
            var result = new List<int>();
            foreach (var t in timePoints)
            {
                var tim = GetInMinute(t);
                result.Add(tim);
                result.Add(tim + 1440);
            }
            result.Sort();
            var min = Int32.MaxValue;
            for (int i = 0; i < result.Count - 1; i++)
                min = Math.Min(min, result[i + 1] - result[i]);
            return min;
        }
        public int GetInMinute(string time)
        {
            var s = time.Split(":");
            return Int32.Parse(s[0]) * 60 + Int32.Parse(s[1]);
        }
    }
}
