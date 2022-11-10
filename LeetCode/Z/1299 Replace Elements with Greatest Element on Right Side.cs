using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1299_Replace_Elements_with_Greatest_Element_on_Right_Side
    {
        /// <summary>
        /// Runtime: 562 ms, faster than 12.76% of C# online submissions for Replace Elements with Greatest Element on Right Side.
        /// Memory Usage: 48.3 MB, less than 28.57% of C# online submissions for Replace Elements with Greatest Element on Right Side.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>

        public static int[] ReplaceElements(int[] arr)
        {
            if (arr == null)
                return new int[0];
            else if (arr.Length == 1)
            {
                var data = new int[1]
                {
                    -1
                };
                return data;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = GetMaxElement(arr, i + 1, arr.Length);
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }

        public static int GetMaxElement(int[] arr, int start, int end)
        {
            int max = 0;
            for (int i = start; i < end; i++)
            {
                max = Math.Max(max, arr[i]);
            }
            return max;
        }
    }
}
