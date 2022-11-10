using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _575
    {
        public int DistributeCandies(int[] candyType)
        {

            return Math.Min(candyType.Distinct().Count(), candyType.Length / 2);
        }
    }
}
