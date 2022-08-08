using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class BFS_Graph_Adjacency
    {
        public void Display() { 
        var paths = new List<(Char, List<Char>)>()
            {
                ('A',new List<Char>() { 'B','F' }),
                ('B',new List<Char>() { 'A','F','C'}),
                ('C',new List<Char>() { 'B','E','D' }),

                ('D',new List<Char>() { 'C','E' }),
                ('E',new List<Char>() { 'D','C','F' }),
                ('F',new List<Char>() { 'A','B','E' }),
            };
            BFS_Graph(paths, 'A');
        }
        public static List<char> BFS_Graph(List<(Char, List<Char>)> paths, char start)
        {
            var result = new HashSet<char>();
            var queue = new Queue<char>();
            queue.Enqueue(start);

            var visited = new List<char>();
        

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                visited.Add(item );
                result.Add(item);

                var neigbours = paths[item];
                for (int i = 0; i < neigbours.Item2.Count; i++)
                {
                    var neighItem = neigbours.Item2[i];
                    if (!visited.Contains(neighItem))
                    {
                        visited.Add(neighItem);
                        queue.Enqueue(neighItem);
                    }
                }
            }
            return result.ToList();
        }
    }
}
