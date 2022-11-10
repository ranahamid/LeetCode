using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _728_Self_Dividing_Numbers
    {

        /// <summary>
        /// Runtime: 107 ms, faster than 76.19% of C# online submissions for Self Dividing Numbers.
        ///  Memory Usage: 38.7 MB, less than 23.81% of C# online submissions for Self Dividing Numbers.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static List<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (IsDividingNumber(i))
                    result.Add(i);
            }
            return result;
        }
        public static bool IsDividingNumber(int n)
        {
            var digits = GetDigits(n);
            foreach (var digit in digits)
            {
                if (digit == 0)
                    return false;
                if (n % digit != 0)
                    return false;


            }
            return true;
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
