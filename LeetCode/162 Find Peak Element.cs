using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _162_Find_Peak_Element
    {
        /// <summary>
        /// Runtime: 148 ms, faster than 17.91% of C# online submissions for Find Peak Element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindPeakElement2(int[] nums)
        {
            //1, 2, 1, 3, 5, 6, 4
            //0, 1, 2, 3, 4, 5, 6
            int prev = int.MinValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > prev && nums[i] > nums[i + 1])
                {
                    return i;
                }
            }
            return nums.Length - 1;
        }

        /// <summary>
        /// Runtime: 95 ms, faster than 80.55% of C# online submissions for Find Peak Element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindPeakElement(int[] nums)
        {
            //1, 2, 1, 3, 5, 6, 4
            //0, 1, 2, 3, 4, 5, 6
            var start = 0;//0
            var end = nums.Length - 1; //5
            int peak = 0;
            while (start <= end)
            {
                if (start == end) //start =5, end = 5
                {
                    peak = start; //5
                    break;
                }
                var mid = (start + end) / 2; //0+5=2 ==>3+5=4 ==> 5+5=10/2=5 ==>
                if (nums[mid] < nums[mid + 1]) // 1<3==>5 <6 ==> 6<4 False==>
                {
                    start = mid + 1; //3==>6 ==> 4+1=5 ==>
                }
                else //
                {
                    end = mid; //=> 5
                }
            }
            return peak;
        }
    }
}
