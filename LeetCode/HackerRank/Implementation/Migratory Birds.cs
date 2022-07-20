using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Migratory_Birds
    {
        public static int migratoryBirds(List<int> arr)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic[arr[i]] = 1;
                }
            }
            var allList = dic.Select(x => x.Value);
            var maxElement = allList.Max();
            var sort = dic.Where(x => x.Value == maxElement).OrderBy(x => x.Key).FirstOrDefault();
            return sort.Key;

        }
    }
}
