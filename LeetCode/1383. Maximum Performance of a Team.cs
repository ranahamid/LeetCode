using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1383
    {
        public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
        {
            var BigMod = (int)Math.Pow(10, 9) + 7;
            var candidates = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                candidates.Add(new List<int> { efficiency[i], speed[i] });
            }
            candidates = candidates.OrderByDescending(x => x[0]).ToList();
            var pq = new PriorityQueue<int, int>();
            long currentSum = 0;
            long result = 0;
            for (int i = 0; i < candidates.Count; i++)
            {
                if (pq.Count == k)
                {
                    var num = pq.Dequeue();
                    currentSum -= num;
                }
                pq.Enqueue(candidates[i][1], candidates[i][1]);
                currentSum += candidates[i][1];
                result = Math.Max(result, currentSum * candidates[i][0]);
            }
            return (int)(result % BigMod);
        }
        /// <summary>
        /// Runtime: 350 ms, faster than 20.00% of C# online submissions for Maximum Performance of a Team.
        /// Memory Usage: 52.8 MB, less than 40.00% of C# online submissions for Maximum Performance of a Team.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="speed"></param>
        /// <param name="efficiency"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaxPerformance_1(int n, int[] speed, int[] efficiency, int k)
        {
            var BigMod = (int)Math.Pow(10, 9) + 7;
            (int speed, int efficiency)[] enginners = new (int speed, int efficiency)[n];

            for (int i = 0; i < n; i++)
            {
                enginners[i] = (speed[i], efficiency[i]);
            }
            Array.Sort(enginners, (a, b) => b.efficiency.CompareTo(a.efficiency));




            var pq = new PriorityQueue<int, int>();

            long currentSum = 0;
            long result = 0;
            checked
            {
                for (int i = 0; i < enginners.Length; i++)
                {
                    if (pq.Count == k)
                    {
                        currentSum -= pq.Dequeue();
                    }
                    currentSum += enginners[i].speed;
                    pq.Enqueue(enginners[i].speed, enginners[i].speed);
                    result = Math.Max(result, currentSum * enginners[i].efficiency);
                }
            }

            return (int)(result % 1_000_000_007);
        }
    }
}
