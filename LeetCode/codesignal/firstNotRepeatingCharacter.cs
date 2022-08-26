using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class firstNotRepeatingCharacter
    {
        char solution(string s)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach(var ch in s)
            {
                if (result.ContainsKey(ch))
                {
                    result[ch]++;
                }
                else
                {
                    result[ch] = 1;
                }
            }
            foreach(var item in result)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return '_';
        }

    }
}
