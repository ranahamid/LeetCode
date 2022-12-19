using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1971
    {
        /// <summary>
        /// Runtime 756 ms Beats 72.59% Memory 123.6 MB Beats 7.78%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var visited = new bool[n];
            var dic = new Dictionary<int, List<int>>();
            foreach (var item in edges)
            {
                dic.TryAdd(item[0], new List<int>());
                dic.TryAdd(item[1], new List<int>());
                dic[item[0]].Add(item[1]);
                dic[item[1]].Add(item[0]);
            }
            return DFS(dic, visited, source, destination);
        }

        public bool DFS(Dictionary<int, List<int>> path, bool[] visited, int start, int destination)
        {
            if (start == destination)
            {
                return true;
            }
            if (!visited[start])
            {
                visited[start] = true;
                foreach (var child in path[start])
                {
                    if (DFS(path, visited, child, destination))
                        return true;
                }

            }
            return false;
        }
    }
    public class Solution_TLE_1971
    {
        public static HashSet<int> Visited = new HashSet<int>();
        public static HashSet<int> result = new HashSet<int>();

        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            result = new HashSet<int>();
            var dic = new Dictionary<int, List<int>>();
            foreach (var item in edges)
            {

                dic.TryAdd(item[0], new List<int>());
                dic.TryAdd(item[1], new List<int>());
                dic[item[0]].Add(item[1]);
                dic[item[1]].Add(item[0]);
            }
            DFS(dic, source);
            return result.Contains(destination);
        }

        public static void DFS(Dictionary<int, List<int>> path, int start)
        {
            result.Add(start);
            Visited.Add(start);

            var childrens = path.Where(x => x.Key == start).Select(x => x.Value).FirstOrDefault();
            if (childrens != null)
            {
                foreach (var child in childrens)
                {
                    if (!Visited.Contains(child))
                    {
                        DFS(path, child);
                    }
                }
            }
        }


    }
}
