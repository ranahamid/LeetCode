using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1086
    {
        public int[][] HighFive(int[][] items)
        {
            SortedList<int, List<int>> studentMarks = new SortedList<int, List<int>>();
            foreach (var item in items)
            {
                if (studentMarks.ContainsKey(item[0]))
                {
                    studentMarks[item[0]].Add(item[1]);
                }
                else
                {
                    studentMarks.Add(item[0], new List<int>() { item[1] });
                }
            }
            List<int[]> result = new List<int[]>();
            foreach (var item in studentMarks)
            {
                int avg = 0;
                var list = item.Value;
                if (list.Count <= 5)
                {
                    avg = (int)list.Average();
                }
                else
                {
                    list.Sort();
                    list.Reverse();
                    var top5List = list.Take(5);
                    avg = (int)top5List.Average();
                }
                int[] data = new int[2];
                data[0] = item.Key;
                data[1] = avg;
                result.Add(data);

            }
            return result.ToArray();
        }
    }
}
