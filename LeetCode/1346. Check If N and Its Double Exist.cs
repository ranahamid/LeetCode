using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1346
    {
        /// <summary>
        /// Runtime: 107 ms, faster than 89.80% of C# online submissions for Check If N and Its Double Exist.
        /// Memory Usage: 40.9 MB, less than 12.75% of C# online submissions for Check If N and Its Double Exist.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] * 2 == arr[j])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
