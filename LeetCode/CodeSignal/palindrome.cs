using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CodeSignal
{
    internal class palindrome
    {
        bool solution(string inputString)
        {
            int i = 0;
            int j = inputString.Length - 1;
            while (j >= 0)
            {
                if (inputString[i] != inputString[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }

    }
}
