using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1306
    {
        /// <summary>
        /// Runtime: 200 ms, faster than 66.67% of C# online submissions for Jump Game III.
        /// Memory Usage: 47.4 MB, less than 59.68% of C# online submissions for Jump Game III.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public bool CanReach(int[] arr, int start)
        {
            if (start >= 0 && start < arr.Length && arr[start] >= 0)
            {
                if (arr[start] == 0)
                    return true;
                arr[start] *= -1;
                return CanReach(arr, start + arr[start]) || CanReach(arr, start - arr[start]);
            }
            return false;
        }
    }
}
