using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codility
{
    internal class triangle
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < 3)
                return 0;
            for(int i = 2; i < A.Length; i++)
            {
                //if ( (long)(A[i - 2] + A[i - 1]) > A[i] && (long)(A[i - 2] + A[i]) > A[i - 1])
                //    return 1;

                if (A[i-2]>=0 && A[i-2]> A[i] - A[i-1])
                    return 1;
            }
            return 0;
        }
    }
}
