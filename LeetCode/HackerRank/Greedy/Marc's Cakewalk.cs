using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Greedy
{
    internal class Marc_s_Cakewalk
    {
        public static long marcsCakewalk(List<int> calorie)
        {
            calorie.Sort();
            calorie.Reverse();
            long sum = 0;
            var counter = 0;
            foreach (var item in calorie)
            {
                sum += (long)Math.Pow(2, counter) * item;
                counter++;
            }
            return sum;
        }
    }
}
