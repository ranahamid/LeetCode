using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class caesarCipherT
    {
        public static string caesarCipher(string s, int k)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(sb[i]))
                {
                    var next = 0;
                    if (char.IsLower(sb[i]))
                    {
                        next = sb[i] + k - 97;
                        if (next >= 26)
                        {
                            next = next % 26;
                        }
                        next += 97;
                    }

                    if (char.IsUpper(sb[i]))
                    {
                        next = sb[i] + k - 65;
                        if (next >= 26)
                        {
                            next = next % 26;
                        }
                        next += 65;
                    }
                    sb[i] = (char)next;
                }
            }
            return sb.ToString();
        }
    }
}
