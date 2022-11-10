using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2032_Two_Out_of_Three
    {
        /// <summary>
        /// Runtime: 324 ms, faster than 8.82% of C# online submissions for Two Out of Three.
        /// Memory Usage: 45.5 MB, less than 60.29% of C# online submissions for Two Out of Three.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <param name="nums3"></param>
        /// <returns></returns>
        public static List<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            var a = nums1.Select(x => x).Distinct().ToArray();
            var b = nums2.Select(x => x).Distinct().ToArray();
            var c = nums3.Select(x => x).Distinct().ToArray();
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int num in a)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 1;
                }
            }
            //two
            foreach (int num in b)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                    result[num] = 1;
            }
            //two
            foreach (int num in c)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                    result[num] = 1;
            }
            List<int> data = new List<int>();
            foreach (var item in result)
            {
                if (item.Value > 1)
                {
                    data.Add(item.Key);
                }
            }
            return data;
        }
    }
}
