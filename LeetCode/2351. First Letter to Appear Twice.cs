using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2351
    {
        public char RepeatedCharacter(string s)
        {
            var dic = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (dic.ContainsKey(ch)) return ch;
                dic[ch] = 1;
            }
            return 'a';
        }
    }
}
