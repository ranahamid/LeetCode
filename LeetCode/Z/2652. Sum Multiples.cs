using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2652
    {/// <summary>
     /// Runtime: 41 ms, faster than 100.00% of C# online submissions for Sum Multiples.
     ///   Memory Usage: 27.7 MB, less than 100.00% of C# online submissions for Sum Multiples.
     /// </summary>
     /// <param name="n"></param>
     /// <returns></returns>
        public int SumOfMultiples(int n)
        {

            return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0 || x % 7 == 0).Sum();
        }
        public int SumOfMultiples_1(int n)
        {
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
