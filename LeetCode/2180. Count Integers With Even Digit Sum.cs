using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2180
    {   /// <summary>
        /// Runtime: 48 ms, faster than 14.89% of C# online submissions for Count Integers With Even Digit Sum.
        /// Memory Usage: 28 MB, less than 6.38% of C# online submissions for Count Integers With Even Digit Sum.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int CountEven(int num)
        {

            var count = 0;
            for (int i = 2; i <= num; i++)
            {
                var digts = GetDigits(i);
                var sum = digts.Sum();
                if (sum % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static Stack<int> GetDigits(int source)
        {
            Stack<int> digits = new Stack<int>();
            while (source > 0)
            {
                var digit = source % 10;
                digits.Push(digit);
                source = source / 10;
            }
            return digits;
        }
    }
}
