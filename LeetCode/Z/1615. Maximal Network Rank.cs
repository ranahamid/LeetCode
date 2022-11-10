using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1615
    {
        public int MaximalNetworkRank(int n, int[][] roads)
        {
            var dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                dic.TryAdd(i, new List<int>());
            }
            for (int i = 0; i < roads.Length; i++)
            {
                dic[roads[i][0]].Add(roads[i][1]);
                dic[roads[i][1]].Add(roads[i][0]);
            }
            int max = 0;
            //loop all the possible pairs, if the two node are connected, minus 1
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int size = dic[i].Count + dic[j].Count;
                    if (dic[i].Contains(j))
                        size--;
                    max = Math.Max(max, size);
                }
            }

            return max;
        }
    }
}
