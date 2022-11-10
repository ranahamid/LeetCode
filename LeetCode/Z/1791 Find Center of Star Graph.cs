using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1791_Find_Center_of_Star_Graph
    {
        /// <summary>
        /// Runtime: 272 ms, faster than 97.42% of C# online submissions for Find Center of Star Graph.
        /// Memory Usage: 62.3 MB, less than 5.15% of C# online submissions for Find Center of Star Graph.
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        public int FindCenter(int[][] edges)
        {
            var result = edges[0][0];
            if (result == edges[1][0] || result == edges[1][1])
                return result;
            else
                return edges[0][1];
        }
    }
}
