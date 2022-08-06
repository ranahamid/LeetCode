using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _299
    {
        /// <summary>
        /// Runtime: 137 ms, faster than 31.82% of C# online submissions for Bulls and Cows.
        /// Memory Usage: 36.5 MB, less than 80.52% of C# online submissions for Bulls and Cows.
        /// </summary>
        /// <param name="secret"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public string GetHint(string secret, string guess)
        {
            var sF = new Dictionary<char, int>();
            var gF = new Dictionary<char, int>();
            var bull = 0;
            var cow = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bull++;
                }
                else
                {
                    //sf
                    if (sF.ContainsKey(secret[i]))
                    {
                        sF[secret[i]]++;
                    }
                    else
                    {
                        sF[secret[i]] = 1;
                    }
                    //gf
                    if (gF.ContainsKey(guess[i]))
                    {
                        gF[guess[i]]++;
                    }
                    else
                    {
                        gF[guess[i]] = 1;
                    }
                }
            }
            foreach (var item in gF)
            {
                if (sF.ContainsKey(item.Key))
                {
                    var sfVal = sF[item.Key];
                    cow += Math.Min(sfVal, item.Value);
                }
            }
            return String.Format($"{bull}A{cow}B");
        }
    }
}
