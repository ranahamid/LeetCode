using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class BFS_Graph_Adjacency_Matrix
    {
        public void Display()
        {
            var paths = new List<List<int>>()
            {
                 new List<int>() { 0,1,0,0,0,1 },
                 new List<int>() { 1,0,1,0,0,1},
                 new List<int>() { 0,1,0,1,1,0 },

                 new List<int>() { 0,0,1,0,1,0},
                 new List<int>() {0,0,1,1,0,1 },
                 new List<int>() { 1,1,0,0,1,0 },
            };

            BFS_Graph(paths, 'A');
        }
        public List<char> BFS_Graph(List<List<int>> paths, char start)
        {
            var vertices = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            var vertexIndices = new Dictionary<char, int>()
        {
          { 'A', 0 },
          { 'B', 1 },
          { 'C', 2 },
          { 'D', 3 },
          { 'E', 4 },
          { 'F', 5 },
        };

            var result = new List<char>();
            var queue = new Queue<char>();
            queue.Enqueue(start);

            var visited = new List<char>();
            visited.Add(start);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                result.Add(item);

                var neigbours = paths[vertexIndices[item]];//paht[0]

                for (int i = 0; i < neigbours.Count; i++)
                {

                    if (neigbours[i] == 1 && !visited.Contains(vertices[i]))
                    {
                        visited.Add(vertices[i]);
                        queue.Enqueue(vertices[i]);
                    }
                }
            }
            return result;
        }
    }
}
