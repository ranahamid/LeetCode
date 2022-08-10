using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1056
    {
        /// <summary>
        /// Runtime: 40 ms, faster than 80.95% of C# online submissions for Confusing Number.
        /// Memory Usage: 29.6 MB, less than 9.52% of C# online submissions for Confusing Number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool ConfusingNumber(int n)
        {
            var digits = GetDigits(n).Reverse();
            var inValid = new int[] { 2, 3, 4, 5, 7 };
            var newNumber = 0;
            foreach (var item in digits)
            {
                if (inValid.Contains(item))
                    return false;
                var degreeNum = item;
                if (item == 6)
                    degreeNum = 9;
                if (item == 9)
                    degreeNum = 6;
                newNumber = newNumber * 10 + degreeNum;
            }
            if (newNumber == n)
                return false;
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
