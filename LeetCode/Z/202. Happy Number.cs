using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _202
    {
        /// <summary>
        /// Runtime: 52 ms, faster than 46.80% of C# online submissions for Happy Number.
        /// Memory Usage: 27.3 MB, less than 78.72% of C# online submissions for Happy Number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsHappy(int n)
        {
            HashSet<int> visited = new HashSet<int>();
            while (n != 1)
            {
                if (visited.Contains(n))
                {
                    return false;
                }
                visited.Add(n);
                n = GetDigitSum(n);
            }
            return true;
        }
        public static int GetDigitSum(int source)
        {
            var sum = 0;
            while (source > 0)
            {
                var digit = source % 10;
                sum += digit * digit;
                source = source / 10;
            }
            return sum;
        }
    }
}
