using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Week_2
{
    internal class Lonely_Integer
    {
        public static int lonelyinteger(List<int> a)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (dic.ContainsKey(a[i]))
                {
                    dic[a[i]]++;
                }
                else
                {
                    dic[a[i]] = 1;
                }
            }
            foreach (var item in dic)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return -1;
        }
    }
}
