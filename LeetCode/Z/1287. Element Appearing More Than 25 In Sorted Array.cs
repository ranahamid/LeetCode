using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1287
    {
        #region n
        /// <summary>
        /// Runtime: 137 ms, faster than 61.54% of C# online submissions for Element Appearing More Than 25% In Sorted Array.
        /// Memory Usage: 39.6 MB, less than 75.00% of C# online submissions for Element Appearing More Than 25% In Sorted Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindSpecialInteger(int[] arr)
        {
            var n = arr.Length;
            var t = n / 4;
            for (int i = 0; i < n - t; i++)
            {
                if (arr[i] == arr[i + t])
                    return arr[i];
            }
            return -1;
        }
        #endregion
        #region frequency
        /// <summary>
        /// Runtime: 161 ms, faster than 42.31% of C# online submissions for Element Appearing More Than 25% In Sorted Array.
        /// Memory Usage: 40.8 MB, less than 30.77% of C# online submissions for Element Appearing More Than 25% In Sorted Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindSpecialInteger_2(int[] arr)
        {
            var sf = GetFrequencyInt(arr);
            var n = arr.Length;
            foreach (var item in sf)
            {
                if (item.Value / (double)n * 100 > 25)
                    return item.Key;
            }
            return -1;
        }
        public static Dictionary<int, int> GetFrequencyInt(int[] s)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (map.ContainsKey(s[index]))
                {
                    map[s[index]]++;
                }
                else
                {
                    map[s[index]] = 1;
                }
            }
            return map;
        }
        #endregion
    }
}
