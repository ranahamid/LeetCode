using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _218
    {
        /// <summary>
        /// Runtime
        //248 ms
        //Beats
        //70.91%
        //Memory
        //48.3 MB
        //Beats
        //18.18%
        /// </summary>
        /// <param name="buildings"></param>
        /// <returns></returns>
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            var set = new SortedSet<int>();
            foreach (var building in buildings)
            {
                set.Add(building[0]);
                set.Add(building[1]);
            }
            var edges = new List<int>(set);
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < edges.Count; i++)
            {
                dic.Add(edges[i], i);
            }
            var heights = new int[edges.Count];
            foreach (var building in buildings)
            {
                int left = building[0], right = building[1], top = building[2];
                int leftIndex = dic[left], rightIndex = dic[right];
                for (int i = leftIndex; i < rightIndex; i++)
                {
                    heights[i] = Math.Max(top, heights[i]);
                }
            }
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < heights.Length; i++)
            {
                int position = edges[i];
                int currentHeight = heights[i];
                if (result.Count == 0 || result.LastOrDefault()[1] != currentHeight)
                {
                    result.Add(new List<int>() { position, currentHeight });
                }
            }
            return result;
        }
    }
}
