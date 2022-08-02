using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1417
    {
        /// <summary>
        /// Runtime: 107 ms, faster than 80.00% of C# online submissions for Reformat The String.
        /// Memory Usage: 37.4 MB, less than 52.50% of C# online submissions for Reformat The String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Reformat(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            var letters = new List<char>();
            var digits = new List<char>();
            foreach (var item in s)
            {
                if (char.IsLetter(item))
                {
                    letters.Add(item);
                }
                else
                {
                    digits.Add(item);
                }
            }

            var lc = letters.Count;
            var dc = digits.Count;
            if (lc == 0 || dc == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            if (lc > dc && lc == dc + 1)
            {
                int i;
                for (i = 0; i < dc; i++)
                {
                    sb.Append(letters[i]);
                    sb.Append(digits[i]);
                }
                sb.Append(letters[i]);
            }
            else if (dc > lc && dc == lc + 1)
            {
                int i;
                for (i = 0; i < lc; i++)
                {
                    sb.Append(digits[i]);
                    sb.Append(letters[i]);

                }
                sb.Append(digits[i]);
            }
            else if (dc == lc)
            {
                int i;
                for (i = 0; i < lc; i++)
                {
                    sb.Append(digits[i]);
                    sb.Append(letters[i]);

                }
            }

            return sb.ToString();
        }
    }
}
