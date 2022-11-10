using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _599
    {
        /// <summary>
        /// Runtime: 320 ms, faster than 25.42% of C# online submissions for Minimum Index Sum of Two Lists.
        /// Memory Usage: 46.6 MB, less than 95.48% of C# online submissions for Minimum Index Sum of Two Lists.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var result = new List<string>();
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j] && !dic.ContainsKey(list1[i]))
                    {
                        dic[list1[i]] = i + j;
                    }
                }
            }
            var min = dic.Select(x => x.Value).Min();
            foreach (var item in dic)
            {
                if (item.Value == min)
                    result.Add(item.Key);
            }
            return result.ToArray();
        }
    }
}
