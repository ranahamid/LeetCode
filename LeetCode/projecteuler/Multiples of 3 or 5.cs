using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.projecteuler
{
    internal class Multiples_of_3_or_5
    {
        public int GetVal()
        {
            var set = new HashSet<int>();
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    set.Add(i);
            }
            return set.Sum();
        }
    }
}
