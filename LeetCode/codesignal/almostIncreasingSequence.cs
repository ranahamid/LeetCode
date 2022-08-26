using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class almostIncreasingSequence
    {
        bool solution(int[] sequence)
        {
            var counter = 0;
            if (sequence.Length == 2 && sequence[0] == sequence[1])
                return true;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    if (i > 1 && sequence[i - 2] >= sequence[i])
                    {
                        sequence[i] = sequence[i - 1];
                    }
                    counter++;
                }
                if (counter > 1)
                    return false;
            }
            return true;
        }

    }
}
