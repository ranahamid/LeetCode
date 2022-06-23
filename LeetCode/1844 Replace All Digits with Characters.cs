using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1844_Replace_All_Digits_with_Characters
    {

        /// <summary>
        /// Runtime: 126 ms, faster than 22.97% of C# online submissions for Replace All Digits with Characters.
        /// Memory Usage: 35.7 MB, less than 72.97% of C# online submissions for Replace All Digits with Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReplaceDigits(string s)
        {
            var data = s.ToCharArray();
            for (int i = 0; i < data.Length; i = i + 2)
            {
                var ch = data[i];
                if (i + 1 < data.Length)
                {
                    var numbr = data[i + 1];
                    int.TryParse(numbr.ToString(), out int number);
                    var letter = ((int)ch + numbr - 48);
                    data[i + 1] = (char)letter;
                }

            }
            var d = new string(data);
            return d;
        }
    }
}
