using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class isLucky
    {
        bool solution(int n)
        {
            var digits= GetDigits(n);
            var half = digits.Count / 2;
            int sum1 = 0, sum2 = 0;
            for(int i = 0; i < digits.Count; i++)
            {
                if(i<half)
                    sum1+=digits[i];
                else
                    sum2+=digits[i];
            }
            if (sum1 == sum2)
                return true;
            return false;
        }
        public static List<int> GetDigits(int source)
        {
            var digits = new List<int>();
            while (source > 0)
            {
                var digit = source % 10;
                digits.Add(digit);
                source = source / 10;
            }
            return digits;
        }
    }
}
