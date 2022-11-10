using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _989
    {
        /// <summary>
        /// Runtime: 221 ms, faster than 76.71% of C# online submissions for Add to Array-Form of Integer.
        /// Memory Usage: 45.8 MB, less than 89.04% of C# online submissions for Add to Array-Form of Integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in num)
            {
                sb.Append(item.ToString());
            }
            var output = AddStrings(sb.ToString(), k.ToString());
            var result = new List<int>();
            foreach (var ch in output)
            {
                result.Add(ch - 48);
            }
            return result;
        }
        public static string AddStrings(string num1, string num2)
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
