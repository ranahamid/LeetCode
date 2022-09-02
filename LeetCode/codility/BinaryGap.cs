using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codility
{
    internal class BinaryGap
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var sb = Convert.ToString(N, 2);
            var max = 0;
            var result = new List<int>();
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '1')
                    result.Add(i);
            }
            for (int i = 1; i < result.Count; i++)
            {
                max = Math.Max(max, result[i] - result[i - 1] - 1);
            }
            return max;
        }

        public int BinaryGap_1(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var sb = Convert.ToString(N, 2);
            var max = 0;
            var lastIndex = Int32.MinValue;
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '1')
                {
                    if (lastIndex >= 0)
                    {
                        max = Math.Max(max, i - lastIndex-1);
                    }
                    lastIndex = i;
                }
            }
            return max;
        }
    }
}
