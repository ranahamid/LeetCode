using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Warm_Up
{
    internal class Compare_The_Triplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var alice = 0;
            var bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
            }
            return new List<int> { alice, bob };
        }
    }
}
