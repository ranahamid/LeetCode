using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2206_Divide_Array_Into_Equal_Pairs
    {

        /// <summary>
        /// O(n)
        /// Runtime: 188 ms, faster than 12.80% of C# online submissions for Divide Array Into Equal Pairs.
        /// Memory Usage: 41.4 MB, less than 37.60% of C# online submissions for Divide Array Into Equal Pairs.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool DivideArray(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map[nums[i]] = 1;
                }
            }
            foreach (var item in map)
            {
                if (item.Value % 2 == 1)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Runtime: 153 ms, faster than 44.00% of C# online submissions for Divide Array Into Equal Pairs.
        /// Memory Usage: 41.2 MB, less than 45.60% of C# online submissions for Divide Array Into Equal Pairs.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool DivideArray_3(int[] nums)
        {
            int pairs = (int)nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] > 0 && nums[i] > 0 && i != j)
                    {
                        if (nums[i] == nums[j])
                        {
                            pairs--;
                            nums[i] = 0; nums[j] = 0;
                        }
                    }
                }
            }
            if (pairs == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Runtime: 213 ms, faster than 5.60% of C# online submissions for Divide Array Into Equal Pairs.
        /// Memory Usage: 41.2 MB, less than 45.60% of C# online submissions for Divide Array Into Equal Pairs.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool DivideArray_2(int[] nums)
        {

            return nums.GroupBy(x => x).Select(x => x.Count()).All(x => x % 2 == 0); ;

        }
    }
}
