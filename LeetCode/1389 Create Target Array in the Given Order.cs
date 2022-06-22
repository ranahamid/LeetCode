using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1389_Create_Target_Array_in_the_Given_Order
    {
        /// <summary>
        /// Runtime: 152 ms, faster than 87.14% of C# online submissions for Create Target Array in the Given Order.
        /// Memory Usage: 42 MB, less than 12.14% of C# online submissions for Create Target Array in the Given Order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }
            return target.ToArray();
        }

    }
}
