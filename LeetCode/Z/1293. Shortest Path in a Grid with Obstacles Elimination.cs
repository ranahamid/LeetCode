using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1293
    {
        /// <summary>
        /// https://leetcode.com/problems/shortest-path-in-a-grid-with-obstacles-elimination/solutions/1425174/shortest-path-in-a-grid-with-obstacles-elimination/
        /// https://leetcode.com/problems/shortest-path-in-a-grid-with-obstacles-elimination/solutions/2263153/c-a-solution/
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int ShortestPath(int[][] grid, int k)
        {
            var minHeap = new PriorityQueue<NodePath, int>();
            var rows = grid.Length;
            var column = grid[0].Length;
            minHeap.Enqueue(new NodePath { Row = rows - 1, Column = column - 1, Weight = -1, Obstacle = k, Steps = 0 }, -1);
            var visited = new Dictionary<string, int>();
            int[][] directions = new int[][]
              {

                new int[] {1,0},
                new int[] {-1,0},
                new int[] {0,1},
                new int[] {0,-1},
              };
            while (minHeap.Count > 0)
            {
                var node = minHeap.Dequeue();
                if (node.Obstacle >= node.Row + node.Column - 1)
                    return node.Steps + node.Row + node.Column;
                foreach (var direction in directions)
                {
                    var newRow = node.Row + direction[0];
                    var newCol = node.Column + direction[1];
                    if (newRow < 0 || newCol < 0 || newRow >= rows || newCol >= column)
                        continue;
                    var newObstacles = grid[newRow][newCol] == 1 ? node.Obstacle - 1 : node.Obstacle;
                    if (newObstacles < 0)
                        continue;
                    var newWeight = newRow + newCol + node.Steps + 1;
                    var neextNode = new NodePath { Row = newRow, Column = newCol, Weight = newWeight, Obstacle = newObstacles, Steps = node.Steps + 1 };
                    var id = $"{newRow}{newCol}";
                    if (!visited.ContainsKey(id) || newObstacles > visited[id])
                    {
                        visited[id] = newObstacles;
                        minHeap.Enqueue(neextNode, newWeight);
                    }
                }
            }
            return -1;
        }
        public class NodePath
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public int Weight { get; set; }
            public int Obstacle { get; set; }
            public int Steps { get; set; }
        }
    }
}
