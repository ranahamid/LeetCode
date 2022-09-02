using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codility
{
    internal class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
                return A;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            K = K % A.Length;
            Array.Reverse(A);
            Array.Reverse(A, 0, K);
            Array.Reverse(A, K, A.Length - K);
            return A;
        }
    }
}
