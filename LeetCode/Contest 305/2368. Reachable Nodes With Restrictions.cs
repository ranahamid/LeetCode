using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_305
{
    internal class _2368
    {
        /// <summary>
        /// TLE
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <param name="restricted"></param>
        /// <returns></returns>
        public int ReachableNodes(int n, int[][] edges, int[] restricted)
        {
            Dictionary<int, HashSet<int>> set = new Dictionary<int, HashSet<int>>();
            foreach (var item in edges)
            {
                if (set.ContainsKey(item[0]))
                {
                    var list = set[item[0]];

                    list.Add(item[1]);
                    //list.Add(item[0]);
                    set[item[0]] = list;
                }
                else
                {
                    var list = new HashSet<int>();
                    list.Add(item[1]);
                    //list.Add(item[0]);
                    set[item[0]] = list;
                }

                if (set.ContainsKey(item[1]))
                {
                    var list = set[item[1]];

                    //list.Add(item[1]);
                    list.Add(item[0]);
                    set[item[1]] = list;
                }
                else
                {
                    var list = new HashSet<int>();
                    //list.Add(item[1]);
                    list.Add(item[0]);
                    set[item[1]] = list;
                }
            }

            List<int> Visited = new List<int>();
            var result = 1;

            var queue = new Queue<int>();
            queue.Enqueue(0);

            var visited = new List<int>();
            visited.Add(0);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                var neigbours = set.Where(x => x.Key == item).Select(x => x.Value).FirstOrDefault();
                if (neigbours != null)
                {
                    var data = neigbours.ToList();
                    for (int i = 0; i < neigbours.Count; i++)
                    {
                        if (!visited.Contains(data[i]) && !restricted.Contains(data[i]))
                        {
                            visited.Add(data[i]);
                            queue.Enqueue(data[i]);
                            result++;
                        }
                    }
                }

            }
            return result;
        }
    }
}
