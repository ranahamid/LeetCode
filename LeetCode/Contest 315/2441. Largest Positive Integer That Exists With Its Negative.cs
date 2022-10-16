using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_315
{
    internal class _2441
    {
        public int FindMaxK(int[] nums)
        {
            var set = new HashSet<int>(nums);
            var result = new List<int>();
            foreach (var item in set)
            {
                result.Add(Math.Abs(item));
            }
            result.Sort((a, b) => b.CompareTo(a));
            for (int i = 1; i < result.Count; i++)
            {
                if (result[i] == result[i - 1])
                    return result[i];
            }
            return -1;
        }
    }
}
