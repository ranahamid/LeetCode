using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1295_Find_Numbers_with_Even_Number_of_Digits
    {
        /// <summary>
        /// Runtime: 174 ms, faster than 5.99% of C# online submissions for Find Numbers with Even Number of Digits.
        /// Memory Usage: 39.5 MB, less than 6.26% of C# online submissions for Find Numbers with Even Number of Digits.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindNumbers(int[] nums)
        {
            int counter = 0;
            foreach (var num in nums)
            {
                var digits = GetDigits(num);
                if (digits.Count() % 2 == 0)
                    counter++;
            }
            return counter;
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
