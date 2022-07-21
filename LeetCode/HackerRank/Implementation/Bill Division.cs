using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Bill_Division
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            var sum = bill.Sum() - bill[k];
            var avg = sum / 2;
            var refund = b - avg;
            if (refund == 0)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(refund);
        }
    }
}
