using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _27_Remove_Element
    {    /// <summary>
         /// Runtime: 189 ms, faster than 50.66% of C# online submissions for Remove Element.
         /// </summary>
         /// <param name="nums"></param>
         /// <param name="val"></param>
         /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            var counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[counter++] = nums[i];
                }
            }
            return counter;
        }
    }
}
