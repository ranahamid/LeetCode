using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1534_Count_Good_Triplets
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 98.84% of C# online submissions for Count Good Triplets.
        /// Memory Usage: 38.6 MB, less than 10.46% of C# online submissions for Count Good Triplets.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }

    }
}
