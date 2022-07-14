using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _168
    {

        /// <summary>
        /// Runtime: 87 ms, faster than 68.25% of C# online submissions for Excel Sheet Column Title.
        /// Memory Usage: 35.5 MB, less than 31.28% of C# online submissions for Excel Sheet Column Title.
        /// self
        /// </summary>
        /// <param name="columnNumber"></param>
        /// <returns></returns>
        public static string ConvertToTitle(int columnNumber)
        {
            var chars = new List<char>();
            while (columnNumber > 0)
            {
                var reminder = columnNumber % 26;
                columnNumber = columnNumber / 26;
                if (reminder == 0)
                {
                    reminder = 26;
                    columnNumber--;
                }
                chars.Add((char)(64 + reminder));
            }
            chars.Reverse();
            return new string(chars.ToArray());
        }

        /// <summary>
        /// Runtime: 113 ms, faster than 27.49% of C# online submissions for Excel Sheet Column Title.
        /// Memory Usage: 35 MB, less than 94.79% of C# online submissions for Excel Sheet Column Title.
        /// </summary>
        /// <param name="columnNumber"></param>
        /// <returns></returns>
        public string ConvertToTitle_2(int columnNumber)
        {
            var chars = new List<char>();
            while (columnNumber > 0)
            {
                columnNumber--;
                var reminder = columnNumber % 26;
                chars.Add((char)(65 + reminder));
                columnNumber = columnNumber / 26;
            }
            chars.Reverse();
            return new string(chars.ToArray());
        }
    }
}
