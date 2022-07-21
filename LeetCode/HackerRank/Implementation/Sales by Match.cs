using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Sales_by_Match
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (dic.ContainsKey(ar[i]))
                    dic[ar[i]]++;
                else
                    dic[ar[i]] = 1;
            }
            var counter = 0;
            foreach (var item in dic)
            {
                if (item.Value > 1)
                {
                    counter += item.Value / 2;
                }
            }
            return counter;
        }
    }
}
