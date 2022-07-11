using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1502
    {
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            if (arr.Length == 0 || arr.Length == 1)
            {
                return false;
            }
            var diff = arr[0] - arr[1];
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i - 1] - arr[i] == diff)
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
