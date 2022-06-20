using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _8_String_to_Integer__atoi_
    {    
        
        /// <summary>
         /// Runtime: 55 ms, faster than 99.47% of C# online submissions for String to Integer (atoi).
         /// </summary>
         /// <param name="s"></param>
         /// <returns></returns> 
        public static int MyAtoi2(string s)
        {
            long result = 0;
            s = s.Trim();
            if (string.IsNullOrEmpty(s))
                return 0;
            var chars = s.ToCharArray();
            var signMag = 1;
            var len = chars.Length;
            var start = 0;
            if (chars[0] == '-')
            {
                signMag = -1; start = 1;
            }
            if (chars[0] == '+')
            {
                signMag = 1; start = 1;
            }
            for (int i = start; i < len; i++)
            {
                if (chars[i] >= 48 && chars[i] <= 57)
                {
                    result = result * 10 + (chars[i] - 48);
                    if (result * signMag > int.MaxValue) return int.MaxValue;
                    if (result * signMag < int.MinValue) return int.MinValue;
                }
                else
                {
                    break;
                }
            }
            return (int)result * signMag;
        }
    }
}
