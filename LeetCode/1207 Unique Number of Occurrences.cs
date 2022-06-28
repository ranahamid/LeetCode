using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1207_Unique_Number_of_Occurrences
    {
        /// <summary>
        /// Runtime: 135 ms, faster than 45.99% of C# online submissions for Unique Number of Occurrences.
        /// Memory Usage: 39.2 MB, less than 34.22% of C# online submissions for Unique Number of Occurrences.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                if (result.ContainsKey(arr[i]))
                {
                    result[arr[i]]++;
                }
                else
                {
                    result[arr[i]] = 1;
                }
            }
            var list = new List<int>();
            foreach (var item in result)
            {
                list.Add(item.Value);
            }
            var dist = list.Select(x => x).Distinct().ToList();
            return list.Count == dist.Count;

        }

    }
}
