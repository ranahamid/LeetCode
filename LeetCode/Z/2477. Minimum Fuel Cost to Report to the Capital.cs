using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2477
    {
        long fuel = 0;
        public long MinimumFuelCost(int[][] roads, int seats)
        {
            var adj = new Dictionary<int, List<int>>();
            foreach (var item in roads)
            {
                adj.TryAdd(item[0], new List<int>());
                adj[item[0]].Add(item[1]);

                adj.TryAdd(item[1], new List<int>());
                adj[item[1]].Add(item[0]);

            }
            dfs(0, -1, adj, seats);
            return fuel;
        }
        public long dfs(int node, int parent, Dictionary<int, List<int>> adj, int seats)
        {
            long respresentative = 1;
            if (!adj.ContainsKey(node))
            {
                return respresentative;
            }
            foreach (var child in adj[node])
            {
                if (child != parent)
                {
                    respresentative += dfs(child, node, adj, seats);
                }
            }
            if (node != 0)
            {
                fuel += (long)Math.Ceiling((double)respresentative / seats);
            }
            return respresentative;
        }
    }
}
