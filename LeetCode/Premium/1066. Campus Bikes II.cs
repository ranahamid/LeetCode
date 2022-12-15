using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1066
    {
        /// <summary>
        /// Runtime 940 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 38.1 MB Beats 100%
        /// </summary>
        int min = Int32.MaxValue;
        public int AssignBikes(int[][] workers, int[][] bikes)
        {
            var visited = new bool[bikes.Length];
            DFS(workers, bikes, visited, 0, 0);
            return min;
        }
        public void DFS(int[][] workers, int[][] bikes, bool[] visited, int i, int prevMin)
        {
            if (i == workers.Length)
                min = Math.Min(min, prevMin);
            else
            {
                for (int j = 0; j < bikes.Length; j++)
                {
                    if (!visited[j])
                    {

                        visited[j] = true;
                        var currentPrevMin = prevMin + Math.Abs(workers[i][0] - bikes[j][0]) + Math.Abs(workers[i][1] - bikes[j][1]);
                        DFS(workers, bikes, visited, i + 1, currentPrevMin);
                        visited[j] = false;
                    }
                }
            }
        }
    }
}
