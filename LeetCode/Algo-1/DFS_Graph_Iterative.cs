using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class DFS_Graph_Iterative
    {
        public static List<char> Visited = new List<char>();
        public static List<char> result = new List<char>();

        public void DFSGraph(List<(Char, List<Char>)> path)
        {
            DFS(path, 'A');
            foreach (var item in result)
                Console.Write(item + " ");
        }
        public static void DFS(List<(Char, List<Char>)> path, char start)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(start);
            Visited.Add(start);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                result.Add(current);

                var childrens = path.Where(x => x.Item1 == current).Select(x => x.Item2).FirstOrDefault();
                if (childrens != null)
                {
                    foreach (var child in childrens)
                    {
                        if (!Visited.Contains(child))
                        {
                            stack.Push(child);
                            Visited.Add(child);
                        }
                    }
                }
            }
        } 
    }
}
