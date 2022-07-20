using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Super_Reduced_String
    {
        public static string superReducedString(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i] == sb[i - 1])
                {
                    sb.Remove(i - 1, 2);
                    i = 0;
                }
            }
            if (sb.Length == 0)
                return "Empty String";
            else
                return sb.ToString();
        }
    }
}
