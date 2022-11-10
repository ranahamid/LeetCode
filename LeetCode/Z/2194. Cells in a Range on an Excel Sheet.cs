using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2194
    {

        /// <summary>
        /// 2194. Cells in a Range on an Excel Sheet
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IList<string> CellsInRange(string s)
        {
            IList<string> result = new List<string>();
            for (char c = s[0]; c <= s[3]; c++)
            {
                for (int i = s[1] - 48; i <= s[4] - 48; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(c);
                    sb.Append(i.ToString());
                    result.Add(sb.ToString());
                }
            }
            return result;

        }

    }
}
