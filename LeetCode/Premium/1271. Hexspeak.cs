using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    class _1271
    {
        public string ToHexspeak(string num)
        {
            var sb = Convert.ToString(long.Parse(num), 16).ToUpper().ToCharArray();
            //var list = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'I', 'O' };
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] >= '2' && sb[i] <= '9')
                {
                    return "ERROR";
                }
                if (sb[i] == '0')
                {
                    sb[i] = 'O';
                }
                else if (sb[i] == '1')
                {
                    sb[i] = 'I';
                }
            }
            return new string(sb);
        }
    }
}
