using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _332
    {
        List<string> result;
        Dictionary<string, PriorityQueue<string, string>> dic;
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            result = new List<string>();
            dic = new Dictionary<string, PriorityQueue<string, string>>();
            foreach (var item in tickets)
            {
                if (!dic.ContainsKey(item[0]))
                {
                    dic.TryAdd(item[0], new PriorityQueue<string, string>());
                }
                dic[item[0]].Enqueue(item[1], item[1]);
            }
            Visit("JFK");
            result.Reverse();
            return result;
        }
        public void Visit(string route)
        {
            while (dic.ContainsKey(route) && dic[route].Count > 0)
            {
                var item = dic[route].Dequeue();
                Visit(item);
            }
            result.Add(route);
        }
    }
}
