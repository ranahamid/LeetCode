using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{ 
    public class DFS_AjacencyList
    {
        public static void Display()
        {
            var pathsAdjacency = new List<(Char, List<Char>)>()
            {
                ('A',new List<Char>() { 'B','F' }),
                ('B',new List<Char>() { 'A','C'}),
                ('C',new List<Char>() { 'B','E','D' }),

                ('D',new List<Char>() { 'C','E' }),
                ('E',new List<Char>() { 'D','C','F' }),
                ('F',new List<Char>() { 'A', 'E' }),
            };
            DFSGraph(pathsAdjacency);
        }
        public static List<char> Visited = new List<char>();
        public static List<char> result = new List<char>();
        public static void DFSGraph(List<(Char, List<Char>)> path)
        {
            DFS(path, 'A');
            foreach (var item in result)
                Console.Write(item + " ");
        }
        public static void DFS(List<(Char, List<Char>)> path, char start)
        {
            result.Add(start);
            Visited.Add(start);

            var childrens = path.Where(x => x.Item1 == start).Select(x => x.Item2).FirstOrDefault();
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
