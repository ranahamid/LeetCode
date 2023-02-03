using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _6
    {
        public string Convert(string s, int numRows)
        {
            var length = s.Length;
            var sb = new StringBuilder[numRows];
            int i;
            for (i = 0; i < numRows; i++)
                sb[i] = new StringBuilder();
            i = 0;
            while (i < length)
            {
                for (int index = 0; index < numRows && i < length; index++)
                    sb[index].Append(s[i++]);

                for (int index = numRows - 2; index >= 1 && i < length; index--)
                    sb[index].Append(s[i++]);
            }
            for (int index = 1; index < numRows; index++)
                sb[0].Append(sb[index]);
            return sb[0].ToString();
        }
    }
}
