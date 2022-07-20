using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Mars_Exploration
    {
        public static int marsExploration(string s)
        {
            var counter = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= 102; i = i + 3)
            {
                sb.Append("S");
                sb.Append("O");
                sb.Append("S");
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != sb[i])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
