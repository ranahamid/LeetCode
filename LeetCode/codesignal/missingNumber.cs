using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class missingNumber
    {
        public int solution(int[] arr)
        {
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i)
                    return i;
            }
            return arr.Length;
        }

    }
}
