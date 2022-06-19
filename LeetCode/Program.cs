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
            int[] nums = new int[] { 2,2};
            var res = SearchRange(nums, 3);
            Console.WriteLine($"{res[0]},{res[1]}");
            Console.ReadKey();
        }
        public static  int[] SearchRange(int[] nums, int target)
        {
            int first = BinarySearch(nums, target, start: 0, end: nums.Length);
            if (first == -1)
                return new int[2] { -1, -1 };
            int left = first;
            while(left>0 && nums[left-1] == target)
            {
                left = BinarySearch(nums, target, start: 0, end: left-1);
            }
            int right = first;
            while(right<nums.Length-1 && nums[right+1]==target)
            {
                right= BinarySearch(nums, target, start: right+1, end: nums.Length-1);
            }
            return new int[2] { left, right };
        }
        public static int BinarySearch(int[] nums, int target, int start, int end )
        {
            //var start = 0;
            //var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = (end + start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
