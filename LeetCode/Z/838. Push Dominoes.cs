using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _838
    {
        /// <summary>
        /// Runtime: 443 ms, faster than 7.69% of C# online submissions for Push Dominoes.
        /// Memory Usage: 45.8 MB, less than 7.69% of C# online submissions for Push Dominoes.
        /// </summary>
        /// <param name="dominoes"></param>
        /// <returns></returns>
        public string PushDominoes(string dominoes)
        {
            while (true)
            {
                var sb = new StringBuilder(dominoes);
                sb.Replace("R.L", "*");
                sb.Replace(".L", "LL");
                sb.Replace("R.", "RR");
                if (sb.ToString() == dominoes)
                    break;
                dominoes = sb.ToString();
            }
            dominoes = dominoes.Replace("*", "R.L");
            return dominoes;
        }
    }
}
