using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Certificate
{
    internal class Road
    {
        public static long getMinCost(List<int> crew_id, List<int> job_id)
        {
            crew_id.Sort();
            job_id.Sort();
            long sum = 0;
            for (int i = 0; i < crew_id.Count; i++)
            {
                sum += Math.Abs(crew_id[i] - job_id[i]);
            }
            return sum;
        }
    }
}
