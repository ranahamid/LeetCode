using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _408
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            int i = 0;
            int j = 0;
            var length = word.Length;
            while (i < length && j < abbr.Length)
            {
                var num = 0;
                if (char.IsDigit(abbr[j]))
                {
                    if (abbr[j] == '0')
                    {
                        return false;
                    }
                    while (j < abbr.Length && char.IsDigit(abbr[j]))
                    {
                        num = num * 10 + Int32.Parse(abbr[j].ToString());
                        j++;
                    }
                    i += num;
                    if (i > length)
                        return false;
                    if (j > abbr.Length)
                        return false;
                }
                else
                {
                    if (word[i] == abbr[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (j != abbr.Length)
                return false;
            if (i != length)
                return false;
            return true;
        }
    }
}
