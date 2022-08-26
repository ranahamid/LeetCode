using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_84
{
    internal class CalculateSum_84
    {
        long solution(int[] a)
        {
            long result = 0;
            long lowSum = 0;
            long offsetSum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                lowSum += a[i];
                long size = a[i].ToString().Length;
                long n = 1;
                for (int j = 1; j <= size; j++)
                {
                    n *= 10;
                }
                offsetSum += n;
            }
            long r = lowSum * a.Length + lowSum * offsetSum;
            return r;
        }


    }
}
