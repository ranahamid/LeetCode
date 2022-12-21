using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _886
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            var visited = new int[n + 1];
            for (int i = 0; i <= n; i++)
                visited[i] = -1;

            var dic = new Dictionary<int, List<int>>();
            foreach (var item in dislikes)
            {
                dic.TryAdd(item[0], new List<int>());
                dic.TryAdd(item[1], new List<int>());
                dic[item[0]].Add(item[1]);
                dic[item[1]].Add(item[0]);
            }
            for (int i = 1; i <= n; i++)
            {
                if (visited[i] == -1)
                    if (DFS(i, visited, dic) == false)
                        return false;
            }
            return true;
        }
        public bool DFS(int index, int[] visited, Dictionary<int, List<int>> dic)
        {
            var stack = new Stack<int>();
            stack.Push(index);
            visited[index] = 0;
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (dic.ContainsKey(node))
                    foreach (var neigbour in dic[node])
                    {
                        if (visited[neigbour] == visited[node])
                        {
                            return false;
                        }
                        if (visited[neigbour] == -1)
                        {
                            visited[neigbour] = 1 - visited[node];
                            stack.Push(neigbour);
                        }
                    }
            }
            return true;
        }
    }
}
