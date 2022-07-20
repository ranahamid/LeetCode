using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Warm_Up
{
    internal class Diagonal_Difference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var array = arr.ToArray();
            var firstSum = 0;
            var secondSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var item = arr[i];
                for (int j = 0; j < item.Count; j++)
                {
                    if (i == j)
                    {
                        firstSum += item[j];
                    }
                    if (i + j == array.Length - 1)
                    {
                        var d = item[j];
                        secondSum += d;
                    }
                }
            }
            return Math.Abs(firstSum - secondSum);
        }
    }
}
