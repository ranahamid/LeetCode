using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _210
    {
        /// Indegree Topological Sort
        /// <summary>
        /// Runtime: 216 ms, faster than 64.42% of C# online submissions for Course Schedule II.
        /// Memory Usage: 45.7 MB, less than 87.83% of C# online submissions for Course Schedule II.
        /// </summary>
        /// <param name="numCourses"></param>
        /// <param name="prerequisites"></param>
        /// <returns></returns>
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, HashSet<int>> set = new Dictionary<int, HashSet<int>>();
            Dictionary<int, int> inDegree = new Dictionary<int, int>();
            //adjacency matrix
            for (int i = 0; i < numCourses; i++)
            {
                inDegree.TryAdd(i, 0);
            }
            foreach (var item in prerequisites)
            {
                set.TryAdd(item[1], new HashSet<int>());
                set[item[1]].Add(item[0]);

                inDegree[item[0]]++;
            }
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            //add indegree 0  
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegree.ContainsKey(i) && inDegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
            int count = 0;
            while (queue.Count > 0)
            {
                count++;
                var current = queue.Dequeue();
                visited.Add(current);

                if (set.ContainsKey(current))
                {
                    foreach (var node in set[current])
                    {
                        inDegree[node]--;
                        if (inDegree[node] == 0)
                            queue.Enqueue(node);

                        if (!visited.Contains(node))
                        {
                            visited.Add(current);
                        }
                    }
                }
            }
            if (count == numCourses)
                return visited.ToArray();
            else
                return new int[0];
        }
    }
}
