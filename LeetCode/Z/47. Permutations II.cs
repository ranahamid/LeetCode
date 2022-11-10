using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _47
    {

        /// <summary>
        /// Runtime: 292 ms, faster than 19.25% of C# online submissions for Permutations II.
        /// Memory Usage: 60 MB, less than 5.16% of C# online submissions for Permutations II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>();
            var num = nums.Length;
            result = Permute(nums, 0, num - 1, result);
            var data = new List<IList<int>>();
            //using hashset, with increasing number between then
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in result)
            {
                var u = item.ToList();
                //u.Sort();
                var p = printNumber(u.ToArray());
                if (!map.ContainsKey(p))
                {
                    data.Add(item);
                    map[p] = p;
                }
            }
            return data;
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
        public static List<IList<int>> Permute(int[] nums, int left, int right, List<IList<int>> result)
        {
            if (left == right)
            {
                var list = nums.ToList();
                result.Add(list);
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

        public static void swap(int[] nums, int left, int right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
        }


    }
}
