using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _43
    {
        /// <summary>
        /// Runtime: 112 ms, faster than 70.53% of C# online submissions for Multiply Strings.
        /// Memory Usage: 37 MB, less than 83.13% of C# online submissions for Multiply Strings.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";
            var len1 = num1.Length;
            var len2 = num2.Length;
            var len = len1 + len2;
            var product = new int[len];
            for (int i = len1 - 1; i >= 0; i--)
            {
                int a = num1[i] - 48;
                for (int j = len2 - 1; j >= 0; j--)
                {
                    int b = num2[j] - 48;

                    var idx = i + j + 1;
                    var total = a * b + product[idx];
                    product[idx] = total % 10;
                    product[idx - 1] += total / 10;
                }
            }
            var start = 0;
            if (product[0] == 0)
                start++;
            StringBuilder sb = new StringBuilder();
            for (int i = start; i < len; i++)
            {
                sb.Append(product[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Runtime: 119 ms, faster than 65.04% of C# online submissions for Multiply Strings.
        /// Memory Usage: 37.5 MB, less than 56.50% of C# online submissions for Multiply Strings.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Multiply_Big(string num1, string num2)
        { 
            return (BigInteger.Parse(num1) * BigInteger.Parse(num2)).ToString(); 
        }
    }
}
