using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class singleNumber
    {
        int solution(int[] nums)
        {
            int res = 0;
            foreach (int num in nums)
            {
                 res^=num;
            }
            return res;
        }

    }
}
