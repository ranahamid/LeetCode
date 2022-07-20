using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Week_1
{
    internal class Breaking_the_Records
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            var max = 0;
            var min = 0;
            var minimum = 0;
            var maximum = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (i == 0)
                {
                    minimum = scores[i];
                    maximum = scores[i];
                }
                else
                {
                    if (scores[i] > maximum)
                    {
                        max++;
                        maximum = scores[i];
                    }
                    if (scores[i] < minimum)
                    {
                        min++;
                        minimum = scores[i];
                    }
                }
            }
            return new List<int> { max, min };
        }
    }
}
