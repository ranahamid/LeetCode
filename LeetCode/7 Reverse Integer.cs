using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Reverse_Integer
    {
        /// <summary>
        /// Runtime: 40 ms, faster than 34.57% of C# online submissions for Reverse Integer.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {

            var minusInd = 1;
            if (x < 0)
            {
                minusInd = -1;
            }
            var temp = x * minusInd;

            var reversedNum = 0;
            while (temp > 0)
            {
                if (reversedNum * minusInd > int.MaxValue / 10 || reversedNum * minusInd < int.MinValue / 10)
                {
                    return 0;
                }
                reversedNum = reversedNum * 10 + temp % 10;
                temp = temp / 10;
            }
            return reversedNum * minusInd;
        }
    }
}
