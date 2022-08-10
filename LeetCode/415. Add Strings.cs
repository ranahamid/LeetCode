using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _415
    {
        /// <summary>
        /// Runtime: 103 ms, faster than 74.74% of C# online submissions for Add Strings.
        /// Memory Usage: 37.8 MB, less than 43.69% of C# online submissions for Add Strings.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string AddStrings(string num1, string num2)
        {
            var n1Len = num1.Length;
            var n2Len = num2.Length;
            var max = Math.Max(n2Len, n1Len);
            num1 = num1.PadLeft(max, '0');
            num2 = num2.PadLeft(max, '0');
            StringBuilder sb = new StringBuilder();
            var carry = 0;
            var n = 0;
            for (int i = max - 1; i >= 0; i--)
            {
                var sum = num1[i] + num2[i] - 96 + carry;
                n = sum % 10;
                carry = sum / 10;
                sb.Append(n);
            }
            if (carry != 0)
                sb.Append(carry);
            return new string(sb.ToString().ToArray().Reverse().ToArray());
        }
    }
}
