using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1835
    {
        /// <summary>
        /// Runtime: 268 ms, faster than 100.00% of C# online submissions for Find XOR Sum of All Pairs Bitwise AND.
        /// Memory Usage: 51.6 MB, less than 20.00% of C# online submissions for Find XOR Sum of All Pairs Bitwise
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int GetXORSum(int[] arr1, int[] arr2)
        {
            int xor1 = 0, xor2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                xor1 = xor1 ^ arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                xor2 = xor2 ^ arr2[i];
            }
            int result = xor1 & xor2;
            return result;
        }

    }
}
