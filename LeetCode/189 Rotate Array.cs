using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Rotate_Array
    {
        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            reverse(nums, 0, nums.Length - 1);// reverse all
            reverse(nums, 0, k - 1); //reverse first to k-1
            reverse(nums, k, nums.Length - 1); //reverse k to last
            //Console.WriteLine(nums);
        }
        public static void reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {

                //(nums[i], nums[j]) = (nums[j], nums[i]);
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }

        }
        public static void Rotate_2(int[] nums, int k)
        {
            //Runtime: 333 ms, faster than 7.31% of C# online submissions for Rotate Array.
            k = k % nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);

            //            Let n = 7n = 7 and k = 3k = 3.
            //Original List                   : 1 2 3 4 5 6 7
            //After reversing all numbers     : 7 6 5 4 3 2 1
            //After reversing first k numbers: 5 6 7 4 3 2 1
            //After revering last n-k numbers: 5 6 7 1 2 3 4-- > Result
        }
    }
}
