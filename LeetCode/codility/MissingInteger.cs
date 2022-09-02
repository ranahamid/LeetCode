using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codility
{
    internal class MissingInteger
    {
        public int solution(int[] nums)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            SortedSet<int> result = new SortedSet<int>();
            foreach (var n in nums)
            {
                if (n > 0)
                {
                    result.Add(n);
                }
            }
            if (result.Count > 0)
            {
                var list = new List<int>(result);
                if (list[0] != 1)
                {
                    return 1;
                }
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] != list[i - 1] + 1)
                        return list[i - 1] + 1;
                }
                return list[list.Count - 1] + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
