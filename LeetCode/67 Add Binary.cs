using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _67_Add_Binary
    {
        /// <summary>
        /// Runtime: 92 ms, faster than 74.79% of C# online submissions for Add Binary.
        /// Memory Usage: 36.6 MB, less than 94.65% of C# online submissions for Add Binary.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            var achars = a.ToCharArray();
            var bchars = b.ToCharArray();
            int carry = 0;
            for (int i = achars.Length - 1, j = bchars.Length - 1; i >= 0 || j >= 0 || carry > 0; i--, j--)
            {
                var aValue = i < 0 || achars[i] == '0' ? 0 : 1;
                var bValue = j < 0 || bchars[j] == '0' ? 0 : 1;
                var sbValue = (aValue + bValue + carry) % 2;
                carry = (aValue + bValue + carry) / 2;
                sb.Insert(0, sbValue);
            }
            return sb.ToString();
        }
    }
}
