using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_315
{
    internal class _2443
    {
        public bool SumOfNumberAndReverse(int num)
        {
            if (num == 0)
                return true;
            for (int i = 1; i < num; i++)
            {
                if ((i + GetReverse(i)) == num)
                    return true;
            }
            return false;
        }
        static int GetReverse(int source)
        {
            var answer = 0;
            while (source > 0)
            {
                var digit = source % 10;
                answer = answer * 10 + digit;
                source = source / 10;
            }
            return answer;
        }
    }
}
