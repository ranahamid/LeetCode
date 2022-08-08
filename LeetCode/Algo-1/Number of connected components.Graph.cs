using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class Number_of_connected_components
    {
        public static void Display()
        {

            int[][] nums = new int[][]
                      {
                new int[2] {0,1}, new int[2]{1,2}, new int[2]{3,4},
                    new int[2]{5,6},
                      };
            ReachableNodes(7, nums);
        }
        public static int ReachableNodes(int n, int[][] edges)
        {
            Dictionary<int, HashSet<int>> set = new Dictionary<int, HashSet<int>>();
            foreach (var item in edges)
            {
                set.TryAdd(item[0], new HashSet<int>());
                set[item[0]].Add(item[1]);

                set.TryAdd(item[1], new HashSet<int>());
                set[item[1]].Add(item[0]);
            }
            var counter = 0;
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (!visited.Contains(i))
                {
                    counter++;
                    queue.Enqueue(i);
                    visited.Add(i);
                    while (queue.Count > 0)
                    {
                        var item = queue.Dequeue();
                        foreach (var node in set[item])
                        {
                            if (!visited.Contains(node))
                            {
                                visited.Add(node);
                                queue.Enqueue(node);
                            }
                        }
                    }
                }

            }
            return counter;
        }
    }
}
