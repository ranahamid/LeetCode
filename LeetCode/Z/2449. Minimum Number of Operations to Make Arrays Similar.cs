using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2449
    {
        /// <summary>
        /// Runtime 307 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 53.9 MB Beats 100%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public long MakeSimilar(int[] nums, int[] target)
        {
            List<int> odd1 = new List<int>();
            List<int> odd2 = new List<int>();

            List<int> even1 = new List<int>();
            List<int> even2 = new List<int>();

            Array.Sort(nums);
            Array.Sort(target);
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                    even1.Add(item);
                else
                    odd1.Add(item);
            }
            foreach (var item in target)
            {
                if (item % 2 == 0)
                    even2.Add(item);
                else
                    odd2.Add(item);
            }
            long result = 0;
            for (int i = 0; i < odd1.Count; i++)
            {
                if (odd1[i] > odd2[i])
                    result += odd1[i] - odd2[i];
            }
            for (int i = 0; i < even1.Count; i++)
            {
                if (even1[i] > even2[i])
                    result += even1[i] - even2[i];
            }
            return result / 2;
        }
    }
}
