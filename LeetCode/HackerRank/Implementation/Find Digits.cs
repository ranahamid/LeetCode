using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Implementation
{
    internal class Find_Digits
    {
        public static int findDigits(int n)
        {
            var digits = GetDigits(n);
            var counter = 0;
            var len = digits.Count;
            for (int i = 0; i < len; i++)
            {
                var temp = digits.Pop();
                if (temp != 0)
                {

                    if (n % temp == 0)
                        counter++;
                }
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
