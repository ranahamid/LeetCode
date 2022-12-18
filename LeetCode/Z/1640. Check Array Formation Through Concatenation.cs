using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1640
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            var numbers = new List<int>();
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < pieces.Length; j++)
                {
                    if (arr[i] == pieces[j][0])
                        numbers.AddRange(pieces[j]);
                }
            return arr.ToList().SequenceEqual(numbers);
        }
    }
}
