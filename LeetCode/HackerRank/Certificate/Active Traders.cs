using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Certificate
{
    internal class Active_Traders
    {
        public static List<string> mostActive(List<string> customers)
        {
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < customers.Count; i++)
            {
                if (dic.ContainsKey(customers[i]))
                {
                    dic[customers[i]]++;
                }
                else
                {
                    dic[customers[i]] = 1;
                }
            }
            var result = new List<string>();
            var total = customers.Count;
            foreach (var cust in dic)
            {
                var val = cust.Value;
                var percent = (val / (total * 1.0)) * 100.0;
                if (percent >= 5)
                {
                    result.Add(cust.Key);
                }
            }
            result = result.OrderBy(x => x).ToList();
            return result;
        }
    }
}
