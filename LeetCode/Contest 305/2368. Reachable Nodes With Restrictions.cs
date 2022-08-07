using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_305
{
    internal class _2368
    {
        public int ReachableNodes(int n, int[][] edges, int[] restricted)
        {
            Dictionary<int, HashSet<int>> set = new Dictionary<int, HashSet<int>>();
            foreach (var item in edges)
            {
                if (set.ContainsKey(item[0]))
                {
                    var list = set[item[0]];

                    list.Add(item[1]);
                    set[item[0]] = list;
                }
                else
                {
                    var list = new HashSet<int>();
                    list.Add(item[1]);
                    set[item[0]] = list;
                }

                if (set.ContainsKey(item[1]))
                {
                    var list = set[item[1]];
                    list.Add(item[0]);
                    set[item[1]] = list;
                }
                else
                {
                    var list = new HashSet<int>();
                    list.Add(item[0]);
                    set[item[1]] = list;
                }
            }
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            queue.Enqueue(0);
            visited.Add(0);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                foreach (var node in set[item])
                {
                    if (!visited.Contains(node) && !restricted.Contains(node))
                    {
                        visited.Add(node);
                        queue.Enqueue(node);
                    }
                }
            }
            return visited.Count;
        }
    }
}
