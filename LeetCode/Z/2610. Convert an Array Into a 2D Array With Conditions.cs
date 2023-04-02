using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2610
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            var dic = new SortedDictionary<int, int>();
            foreach (var item in nums)
            {
                dic.TryAdd(item, 0);
                dic[item]++;
            }
            var max = dic.Select(x => x.Value).Max();
            var dicItems = dic.Select(x => x.Key).ToList();

            for (int i = 0; i < max; i++)
            {
                List<int> row = new List<int>();
                foreach (var item in dicItems)
                {

                    if (dic[item] > 0)
                    {
                        dic[item]--;
                        row.Add(item);
                    }
                }
                result.Add(row);
            }

            return result;
        }
    }
}
