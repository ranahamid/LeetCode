using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1338
    {
        /// <summary>
        /// Runtime: 251 ms, faster than 80.56% of C# online submissions for Reduce Array Size to The Half.
        /// Memory Usage: 55.4 MB, less than 38.89% of C# online submissions for Reduce Array Size to The Half.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MinSetSize(int[] arr)
        {
            var freq = GetFrequencyInt(arr);
            var val = freq.Select(x => x.Value).ToList();
            val.Sort((a, b) => b.CompareTo(a));
            var length = arr.Length / 2;
            var result = 0;
            var counter = 0;
            while (counter < length)
            {
                counter += val[result];
                result++;
            }
            return result;
        }
        public static Dictionary<int, int> GetFrequencyInt(int[] s)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map[s[i]] = 1;
                }
            }
            return map;
        }
    }
}
