using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Search
{
    internal class Missing_Numbers
    {
        public static Dictionary<int, int> GetNumberFrequency(List<int> arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency[item] = 1;
                }
            }
            return frequency;
        }
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            var num1 = GetNumberFrequency(arr);
            var num2 = GetNumberFrequency(brr);
            var result = new HashSet<int>();
            foreach (var item in num2)
            {
                if (num1.ContainsKey(item.Key))
                {
                    var num1Item = num1[item.Key];
                    if (item.Value > num1Item)
                    {
                        result.Add(item.Key);
                    }
                }
                else
                {
                    result.Add(item.Key);
                }
            }
            var data = result.OrderBy(x => x).ToList();
            return data;
        }

    }
}
