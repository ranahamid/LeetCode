using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2566
    {
        /// <summary>
        /// Runtime: 30 ms, faster than 37.96% of C# online submissions for Maximum Difference by Remapping a Digit.
        /// Memory Usage: 26.8 MB, less than 67.15% of C# online submissions for Maximum Difference by Remapping a Digit.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int MinMaxDifference(int num)
        {
            var n = num.ToString();
            var a = n;
            foreach (var item in n)
            {
                if (item != '9')
                {
                    a = a.Replace(item, '9');
                    break;
                }
            }
            var b = n.Replace(n[0], '0');
            return Int32.Parse(a) - Int32.Parse(b);

        }
    }
}
