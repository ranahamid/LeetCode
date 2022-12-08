using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _323
    {
        /// <summary>
        /// Runtime 101 ms Beats 95.43% Memory 43.3 MB Beats 9.14%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <returns></returns>
        public int CountComponents(int n, int[][] edges)
        {
            var visited = new bool[n];
            var adj = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());
                adj[i] = new List<int>();
            }
            foreach (var item in edges)
            {
                adj[item[0]].Add(item[1]);
                adj[item[1]].Add(item[0]);
            }
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    counter++;
                    DFS(visited, adj, i);
                }
            }
            return counter;
        }
        public void DFS(bool[] visited, List<List<int>> adj, int start)
        {
            visited[start] = true;
            for (int i = 0; i < adj[start].Count; i++)
            {
                if (visited[adj[start][i]] == false)
                    DFS(visited, adj, adj[start][i]);
            }

        }
    }
}
