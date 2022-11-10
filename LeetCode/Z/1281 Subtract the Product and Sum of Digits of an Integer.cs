using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1281_Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
    {

        /// <summary>
        /// Runtime: 29 ms, faster than 67.44% of C# online submissions for Subtract the Product and Sum of Digits of an Integer.
        /// Memory Usage: 27.4 MB, less than 7.77% of C# online submissions for Subtract the Product and Sum of Digits of an Integer.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SubtractProductAndSum(int n)
        {
            var digts = GetDigits(n);
            int sum = digts.Sum();
            int prod = 1;
            foreach (var item in digts)
            {
                prod *= item;
            }
            return prod - sum;
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
