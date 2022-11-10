using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _973
    {
        public int[][] KClosest(int[][] points, int k)
        {
            var dic = new SortedDictionary<int, List<int[]>>();
            foreach (var item in points)
            {
                var ans = item[0] * item[0] + item[1] * item[1];
                dic.TryAdd(ans, new List<int[]>());
                dic[ans].Add(item);
            }
            var result = new List<int[]>();
            var isDone = false;
            var counter = 0;
            foreach (var ans in dic.Values)
            {

                foreach (var item in ans)
                {
                    result.Add(item);
                    counter++;
                    if (counter == k)
                    {
                        isDone = true;
                        break;
                    }
                }
                if (isDone)
                    break;
            }
            return result.ToArray();
        }
    }
}
