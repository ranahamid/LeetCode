using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3467
    {
        public int[] TransformArray(int[] nums)
        {
            var oddCount = 0;
            var evenCount = 0;
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            var result = new List<int>();
            result.AddRange(Enumerable.Repeat(0, evenCount));
            result.AddRange(Enumerable.Repeat(1, oddCount));
            return result.ToArray();
        }
    }
}
