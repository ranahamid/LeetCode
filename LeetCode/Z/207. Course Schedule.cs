using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _207
    {
        ///cycle check
        /// <summary>
        /// Runtime: 593 ms, faster than 5.04% of C# online submissions for Course Schedule.
        /// Memory Usage: 45.9 MB, less than 7.52% of C# online submissions for Course Schedule.
        /// </summary>
        /// <param name="numCourses"></param>
        /// <param name="prerequisites"></param>
        /// <returns></returns>
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, HashSet<int>> set = new Dictionary<int, HashSet<int>>();
            //adjacency matrix
            foreach (var item in prerequisites)
            {
                set.TryAdd(item[1], new HashSet<int>());
                set[item[1]].Add(item[0]);
            }
            //check cycle      
            for (int i = 0; i < numCourses; i++)
            {
                var queue = new Queue<int>();
                var visited = new HashSet<int>();
                if (set.ContainsKey(i))
                {
                    foreach (var item in set[i])
                    {
                        queue.Enqueue(item);
                    }
                }
                while (queue.Count > 0)
                {
                    var item = queue.Dequeue();
                    if (item == i)
                        return false;

                    visited.Add(item);
                    if (set.ContainsKey(item))
                    {
                        foreach (var node in set[item])
                        {
                            if (!visited.Contains(node))
                            {
                                queue.Enqueue(node);
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
