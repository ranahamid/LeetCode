using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_87
{
    internal class _2410
    {
        /// <summary>
        /// Runtime: 549 ms, faster than 100.00% of C# online submissions for Maximum Matching of Players With Trainers.
        /// Memory Usage: 54.2 MB, less than 100.00% of C# online submissions for Maximum Matching of Players With Trainers.
        /// </summary>
        /// <param name="players"></param>
        /// <param name="trainers"></param>
        /// <returns></returns>
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            var pq = new PriorityQueue<int, int>();
            foreach (var item in trainers)
            {
                pq.Enqueue(item, -item);
            }
            int counter = 0;
            Array.Sort(players, (a, b) => b.CompareTo(a));
            foreach (var n in players)
            {
                if (pq.Count > 0)
                {
                    if (pq.Peek() >= n)
                    {
                        counter++;
                        pq.Dequeue();
                    }
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
