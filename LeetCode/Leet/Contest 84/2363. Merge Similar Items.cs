using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_84
{
    internal class _2363
    {
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            List<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            var sum1 = GetCounter(dic, items1);
            var sum2 = GetCounter(sum1, items2);
            var sum3 = sum2.OrderBy(x => x.Key).ToList();
            foreach (var item in sum3)
            {
                result.Add(new List<int>() { item.Key, item.Value });
            }
            return result;
        }
        public Dictionary<int, int> GetCounter(Dictionary<int, int> dic, int[][] items1)
        {
            foreach (var item in items1)
            {
                if (dic.ContainsKey(item[0]))
                {
                    dic[item[0]] += item[1];
                }
                else
                {
                    dic[item[0]] = item[1];
                }
            }
            return dic;
        }
    }
}
