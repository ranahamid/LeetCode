using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _941
    {
        /// <summary>
        /// Runtime: 201 ms, faster than 35.43% of C# online submissions for Valid Mountain Array.
        /// Memory Usage: 42.7 MB, less than 87.17% of C# online submissions for Valid Mountain Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;
            var isMiddleFound = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    return false;
                if (!isMiddleFound)
                {
                    if (arr[i] > arr[i - 1])
                        continue;
                    else if (i == 1)
                        return false;
                    else
                        isMiddleFound = true;
                }
                else
                {
                    if (arr[i] < arr[i - 1])
                        continue;
                    else
                        return false;
                }
            }
            return isMiddleFound;
        }
    }
}
