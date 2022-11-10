using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Z
{
    public class _1636__Sort_Array_by_Increasing_Frequency
    {
        /// <summary>
        /// Runtime: 152 ms, faster than 89.55% of C# online submissions for Sort Array by Increasing Frequency.
        /// Memory Usage: 44.3 MB, less than 17.91% of C# online submissions for Sort Array by Increasing Frequency.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] FrequencySort(int[] nums)
        {

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]]++;
                }
                else
                {
                    dictionary[nums[i]] = 1;
                }
            }
            var data = dictionary.OrderBy(x => x.Value).ThenByDescending(x => x.Key);
            var result = new int[nums.Length];
            var counter = 0;
            foreach (var item in data)
            {
                var value = item.Value;
                var key = item.Key;
                for (int i = 0; i < value; i++)
                {
                    result[counter++] = key;
                }
            }
            return result;
        }

    }
}