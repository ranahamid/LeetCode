using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class Make_Array_Consecutive_2
    {
        int solution(int[] statues)
        {
            var max= statues.Max();
            var min = statues.Min();
            var count = statues.Length;
            return (max - min) + 1 - count;
        }

    }
}
