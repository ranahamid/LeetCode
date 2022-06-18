using System;
using System.Collections.Generic;
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
        }
    }
}
