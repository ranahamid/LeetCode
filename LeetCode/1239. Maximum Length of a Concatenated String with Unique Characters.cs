using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1239
    {
        /// <summary>
        /// Runtime 222 ms Beats 49.15% Memory 40.2 MB Beats 30.51%
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MaxLength(IList<string> arr)
        {
            return GetMax(arr, 0, new StringBuilder());
        }
        public int GetMax(IList<string> arr, int position, StringBuilder result)
        {
            var set = new HashSet<char>();
            for (int i = 0; i < result.Length; i++)
            {
                set.Add(result[i]);
            }
            if (result.Length != set.Count)
                return 0;

            int best = result.Length;
            for (int i = position; i < arr.Count; i++)
            {
                StringBuilder temp = new StringBuilder();
                temp.Append(result);
                temp.Append(arr[i]);

                var current = GetMax(arr, i + 1, temp);
                best = Math.Max(best, current);
            }
            return best;
        }
    }
}
