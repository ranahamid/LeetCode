using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _841
    {
        /// <summary>
        /// Runtime 184 ms Beats 54.25% Memory 41 MB Beats 93.46%
        /// </summary>
        /// <param name="rooms"></param>
        /// <returns></returns>
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var n = rooms.Count;
            var visited = new bool[n];
            var stack = new Stack<int>();

            visited[0] = true;
            stack.Push(0);

            while (stack.Any())
            {
                int node = stack.Pop();
                foreach (var item in rooms[node])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        stack.Push(item);
                    }
                }
            }
            foreach (var item in visited)
            {
                if (!item)
                    return false;
            }
            return true;
        }
    }
}
