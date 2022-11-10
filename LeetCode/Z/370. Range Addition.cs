using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _370
    {
        public int[] GetModifiedArray_TLE(int length, int[][] updates)
        {
            var arr = new int[length];
            foreach (var item in updates)
            {
                var start = item[0];
                var end = item[1];
                var val = item[2];
                for (int i = start; i <= end; i++)
                {
                    arr[i] += val;
                }
            }
            return arr;
        }
    }
}
