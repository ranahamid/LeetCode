using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _405
    {    
        /// <summary>
         /// Runtime: 67 ms, faster than 97.14% of C# online submissions for Convert a Number to Hexadecimal.
         /// Memory Usage: 37 MB, less than 5.71% of C# online submissions for Convert a Number to Hexadecimal.
         /// </summary>
         /// <param name="num"></param>
         /// <returns></returns>
        public string ToHex(int num)
        {
            StringBuilder sb = new StringBuilder();
            if (num == 0) return "0";
            uint n = (uint)num;
            while (n > 0)
            {
                if (n % 16 >= 10)
                {
                    var num1 = n % 16; //10
                    var ch = (char)(97 + num1 % 10); //a
                    sb.Append(ch.ToString());
                }
                else
                {
                    var ch = (char)(48 + n % 16);
                    sb.Append(ch.ToString());
                }
                n /= 16;
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
        /// <summary>
        /// Runtime: 68 ms, faster than 95.71% of C# online submissions for Convert a Number to Hexadecimal.
        /// Memory Usage: 36.9 MB, less than 5.71% of C# online submissions for Convert a Number to Hexadecimal.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string ToHex_2(int num)
        {
            return Convert.ToString(num, 16);
        }
    }
}
