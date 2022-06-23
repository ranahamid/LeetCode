using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _709_To_Lower_Case
    {
        /// <summary>
        /// Runtime: 140 ms, faster than 15.90% of C# online submissions for To Lower Case.
        /// Memory Usage: 37.3 MB, less than 43.82% of C# online submissions for To Lower Case.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ToLowerCase(string s)
        {
            return s.ToLower();
        }



        /// <summary>
        /// Runtime: 84 ms, faster than 92.93% of C# online submissions for To Lower Case.
        /// Memory Usage: 36.9 MB, less than 57.95% of C# online submissions for To Lower Case.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToLowerCase_2(string s)
        {
            var schars = s.ToCharArray();
            for (int i = 0; i < schars.Length; i++)
            {
                if (schars[i] >= 65 && schars[i] <= 90)
                {
                    schars[i] = (char)((int)schars[i] + 32);
                }
            }
            return new string(schars);
        }
    }
}
