using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2160_Minimum_Sum_of_Four_Digit_Number_After_Splitting_Digits
    {
        /// <summary>
        /// Runtime: 28 ms, faster than 77.78% of C# online submissions for Minimum Sum of Four Digit Number After Splitting Digits.
       /// Memory Usage: 26.9 MB, less than 19.56% of C# online submissions for Minimum Sum of Four Digit Number After Splitting Digits.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int MinimumSum(int num)
        {
            var list = GetDigits(num);
            Array.Sort(list);
            var result = list[0] * 10 + list[2] + list[1] * 10 + list[3];
            return result;
        }
        public static int[] GetDigits(int source)
        {
            int[] digits = new int[4];
            var counter = 0;
            while (source > 0)
            {
                var digit = source % 10;
                digits[counter++] = digit;
                source = source / 10;
            }
            return digits;
        }

    }
}
