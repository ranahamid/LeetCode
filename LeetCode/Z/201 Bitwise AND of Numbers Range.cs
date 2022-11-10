using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _201_Bitwise_AND_of_Numbers_Range
    {/// <summary>
     /// Runtime: 32 ms, faster than 91.86% of C# online submissions for Bitwise AND of Numbers Range.
     /// Memory Usage: 27.1 MB, less than 20.93% of C# online submissions for Bitwise AND of Numbers Range.
     /// </summary>
     /// <param name="left"></param>
     /// <param name="right"></param>
     /// <returns></returns>
        public static int RangeBitwiseAnd(int left, int right)
        {
            if (left == right)
                return left;
            var m = Convert.ToString(left, 2);
            var n = Convert.ToString(right, 2);
            if (m.Length != n.Length)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != n[i])
                    break;
                if (m[i] == '1')
                {
                    sum = sum + (int)Math.Pow(2, m.Length - 1 - i);
                }
            }
            return sum;
        }
    }
}
