using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_314
{
    internal class _2432
    {
        /// <summary>
        /// Runtime 202 ms Beats 100%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="logs"></param>
        /// <returns></returns>
        public int HardestWorker(int n, int[][] logs)
        {
            var dicSet = new Dictionary<int, int>();
            int prevTime = 0;
            foreach (var item in logs)
            {
                var currentTime = item[1] - prevTime;
                dicSet.TryAdd(item[0], currentTime);
                if (dicSet.ContainsKey(item[0]))
                {
                    var prev = dicSet[item[0]];
                    if (currentTime > prev)
                    {
                        dicSet[item[0]] = currentTime;
                    }
                }
                prevTime = item[1];
            }
            var maxItem = Int32.MinValue;
            var maxId = Int32.MinValue;
            foreach (var item in dicSet)
            {
                if ((item.Value > maxItem) || (item.Value == maxItem && item.Key < maxId))
                {
                    maxItem = item.Value;
                    maxId = item.Key;
                }
            }
            return maxId;
        }
    }
}
