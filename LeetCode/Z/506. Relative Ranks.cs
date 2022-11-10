using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _506
    {/// <summary>
     /// Runtime: 293 ms, faster than 35.78% of C# online submissions for Relative Ranks.
     /// Memory Usage: 46.9 MB, less than 91.74% of C# online submissions for Relative Ranks.
     /// </summary>
     /// <param name="score"></param>
     /// <returns></returns>
        public string[] FindRelativeRanks(int[] score)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            var len = score.Length;
            for (int i = 0; i < len; i++)
            {
                queue.Enqueue(i, -score[i]);
            }
            var result = new string[len];
            var counter = 0;

            for (int i = 0; i < len; i++)
            {
                counter++;
                var item = queue.Dequeue();
                var res = counter.ToString();
                if (counter == 1)
                    res = "Gold Medal";
                else if (counter == 2)
                    res = "Silver Medal";
                else if (counter == 3)
                    res = "Bronze Medal";
                result[item] = res;
            }
            return result;
        }
    }
}
