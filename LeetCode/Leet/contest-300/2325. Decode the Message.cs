using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_300
{
    internal class _6108
    {
        public static string DecodeMessage(string key, string message)
        {
            var sChars = key.ToCharArray();
            var startChar = 97;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in sChars)
            {
                if (char.IsLower(c) && !dic.ContainsKey(c))
                {
                    dic[c] = startChar;
                    startChar++;
                }
            }
            var msChars = message.ToCharArray();
            for (int i = 0; i < msChars.Length; i++)
            {
                if (char.IsLower(msChars[i]))
                {
                    if (dic.ContainsKey(msChars[i]))
                    {
                        var val = dic[msChars[i]];
                        msChars[i] = (char)val;
                    }
                }
            }
            return new string(msChars);
        }
    }
}
