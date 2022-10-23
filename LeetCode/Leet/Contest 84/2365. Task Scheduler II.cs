using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_84
{
    internal class _2365
    {
        /// <summary>
        /// Runtime: 348 ms, faster than 100.00% of C# online submissions for Task Scheduler II.
        /// Memory Usage: 62.6 MB, less than 100.00% of C# online submissions for Task Scheduler II.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="space"></param>
        /// <returns></returns>
        public long TaskSchedulerII(int[] tasks, int space)
        {
            int n = tasks.Length;
            var map = new Dictionary<long, long>(); 
            var dp = new long[n];
            long currentVal = 0;
            for (int i = 0; i < n; i++)
            {
                if (!map.ContainsKey(tasks[i]))
                {
                    map[tasks[i]] = i;
                    currentVal++;
                    dp[i] = currentVal;
                }
                else
                {
                    currentVal++;
                    int taskNum = 0;
                    if (map.ContainsKey(tasks[i]))
                    {
                        long a = tasks[i];
                        taskNum = (int)map[a];
                    }
                    long reminder = currentVal - dp[taskNum] - 1;
                    long req = Math.Max(0, space - reminder);
                    currentVal += req;
                    dp[i] = currentVal;
                    map[(int)tasks[i]] = i;
                }
            }
            return dp[n - 1];
        }
    }
}
