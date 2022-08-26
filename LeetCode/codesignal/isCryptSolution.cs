using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class isCryptSolution
    {
        public bool solution(string[] crypt, char[][] solution)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            foreach (var item in solution)
            {
                hash[item[0]] = item[1] - 48;
            }
            var aval = GetValOfStr(crypt[0], hash);
            var a = aval.Item1;
            if (!aval.Item2)
                return false;
            var bval = GetValOfStr(crypt[1], hash);
            var b = bval.Item1;
            if (!bval.Item2)
                return false;
            var cval = GetValOfStr(crypt[2], hash);
            var c = cval.Item1;
            if (!cval.Item2)
                return false;
            if (a + b == c)
                return true;
            return false;
        }

        public static (long, bool) GetValOfStr(string word, Dictionary<char, int> hash)
        {
            var result = true;
            StringBuilder sb = new StringBuilder();
            foreach (var ch in word)
            {
                var buid = hash[ch];
                sb.Append(buid);
            }
            long val = long.Parse(sb.ToString());
            if (sb[0] == '0' && sb.Length > 1)
                result = false;
            return (val, result);
        }
    }
}
