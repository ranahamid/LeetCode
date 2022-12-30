using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _797
    {
        readonly List<IList<int>> Result = new List<IList<int>>();
        public int target = 0;
        public int[][] g;
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            target = graph.Length - 1;
            g = graph;
            List<int> path = new List<int>();
            path.Add(0);
            Backtrack(0, path);
            return Result;
        }

        public void Backtrack(int current, List<int> path)
        {
            if (target == current)
            {
                //path.Add(current);
                Result.Add(new List<int>(path));
                return;
            }

            foreach (var nextNode in g[current])
            {
                path.Add(nextNode);
                Backtrack(nextNode, path);
                path.Remove(nextNode);
            }
        }
    }
}
