using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1356_Sort_Integers_by_The_Number_of_1_Bits
    {
        /// <summary>
        /// Runtime: 152 ms, faster than 96.83% of C# online submissions for Sort Integers by The Number of 1 Bits.
        /// Memory Usage: 43.5 MB, less than 57.14% of C# online submissions for Sort Integers by The Number of 1 Bits.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SortByBits(int[] arr)
        {
            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                var count = 0;
                var binary1s = 0;
                var temp = arr[i];
                if (temp != 0)
                {
                    while (temp > 0)
                    {
                        count = count + (temp & 1);
                        temp = temp >> 1;
                    }
                    binary1s = count;
                }
                if (result.ContainsKey(binary1s))
                {
                    result[binary1s].Add(arr[i]);
                }
                else
                {
                    result[binary1s] = new List<int>();
                    result[binary1s].Add(arr[i]);
                }

            }
            //
            var keys = result.Select(x => x.Key).ToList();
            keys.Sort();
            var data = new List<int>();
            foreach (var item in keys)
            {
                if (result.ContainsKey(item))
                {
                    var val = result[item];
                    val.Sort();
                    data.AddRange(val);
                }
            }
            return data.ToArray();
        }


    }
}
