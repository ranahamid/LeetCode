using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _989
    {
        #region array
        public IList<int> AddToArrayForm_1(int[] num, int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= num.Length - 1; i++)
            {
                char ch = (char)(num[i] + 48);
                sb.Append(ch);
            }
            var s = AddStringToNumber(sb.ToString(), k.ToString());

            List<int> result = new List<int>();
            foreach (var st in s)
            {
                result.Add(Int32.Parse(st.ToString()));
            }
            return result;
        }

        public string AddStringToNumber(string a, string b)
        {
            var max1 = a.Length;
            var max2 = b.Length;
            var max = Math.Max(max1, max2);

            a = a.PadLeft(max, '0');
            b = b.PadLeft(max, '0');

            int n = 0;
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = max - 1; i >= 0; i--)
            {
                int c = a[i] + b[i] - 96 + carry;
                sb.Append(c % 10);
                carry = c / 10;
            }
            if (carry != 0)
            {
                sb.Append(carry);
            }
            var st = new string(sb.ToString().Reverse().ToArray());
            return st;
        }
        #endregion
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
