using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _60
    {
        public static string GetPermutation(int n, int k)
        {
            var nums = new int[n];
            for (int i = 1; i <= n; i++)
            {
                nums[i - 1] = i;
            }
            var result = new List<int>();
            var num = nums.Length;
            result = Permute(nums, 0, num - 1, result);
            var data = result.ToArray();
            Array.Sort(data);
            return data[k - 1].ToString();
        }


        public static List<int> Permute(int[] nums, int left, int right, List<int> result)
        {
            if (left == right)
            {
                var number = printNumber(nums);
                result.Add(number);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    swap(nums, left, i);
                    Permute(nums, left + 1, right, result);
                    swap(nums, left, i);
                }
            }
            return result;
        }
        public static int printNumber(int[] nums)
        {
            var sum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                sum = sum * 10 + nums[i];
            }
            return sum;
        }

        public static void swap(int[] nums, int left, int right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
        }
    }
}
