using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            Rotate(nums, 3);
            Console.ReadKey();
        }
        public static void Rotate(int[] nums, int k)
        {
            //Runtime: 333 ms, faster than 7.31% of C# online submissions for Rotate Array.
            k = k % nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k); 
        }
        public static void reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
                j--;
            }

        }
    }

}
