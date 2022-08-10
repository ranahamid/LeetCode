using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1089
    {
        /// <summary>
        /// Runtime: 173 ms, faster than 79.72% of C# online submissions for Duplicate Zeros.
       /// Memory Usage: 44.4 MB, less than 6.76% of C# online submissions for Duplicate Zeros.
        /// </summary>
        /// <param name="arr"></param>
        public void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = arr.Length - 2; j >= i + 1; j--)
                    {
                        arr[j + 1] = arr[j];
                    }
                    arr[i + 1] = 0;
                    i++;
                }
            }
        }
    }
}
