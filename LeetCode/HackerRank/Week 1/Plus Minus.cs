using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Week_1
{
    internal class Plus_Minus
    {
        public static void plusMinus(List<int> arr)
        {
            var plusCount = arr.Where(x => x > 0).Count();
            var minusCount = arr.Where(x => x < 0).Count();
            var zeroCount = arr.Where(x => x == 0).Count();
            var totalCount = arr.Count();
            var plus = plusCount / (double)totalCount;
            var minus = minusCount / (double)totalCount;
            var zero = zeroCount / (double)totalCount;
            Console.WriteLine(string.Format("{0:N6}", plus));
            Console.WriteLine(string.Format("{0:N6}", minus));
            Console.WriteLine(string.Format("{0:N6}", zero));
        }

    }
}
