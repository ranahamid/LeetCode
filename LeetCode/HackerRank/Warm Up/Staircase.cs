using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Warm_Up
{
    internal class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int j = 0; j < i + 1; j++)
                {
                    stringBuilder.Append("#");
                }
                var data = stringBuilder.ToString().PadLeft(n, ' ');
                Console.WriteLine(data);
            }
        }
    }
}
