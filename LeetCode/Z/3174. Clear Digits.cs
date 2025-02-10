using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    class _3174
	{
        public string ClearDigits(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsDigit(sb[i]))
                {
                    sb.Remove(i, 1);
                    i--;
                    if (i >= 0 && char.IsLetter(sb[i]))
                    {
                        sb.Remove(i, 1);
                        i--;
                    }
                }
            }

            return sb.ToString();

        }
	}
}
