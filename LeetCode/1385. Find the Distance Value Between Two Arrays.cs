using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1385
    {
     /// <summary>
        /// Runtime: 101 ms, faster than 84.57% of C# online submissions for Find the Distance Value Between Two Arrays.
        /// Memory Usage: 40.3 MB, less than 11.43% of C# online submissions for Find the Distance Value Between Two Arrays.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int counter = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                bool isAllPassed = true;
                for(int j = 0; j < arr2.Length; j++)
                {
                    var val = Math.Abs(arr1[i] - arr2[j]);
                    if (val <= d)
                    {
                        isAllPassed = false;
                        break;
                    }
                }
                if (isAllPassed)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
