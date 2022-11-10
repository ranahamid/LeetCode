using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1427
    {
        public string StringShift(string s, int[][] shift)
        {
            var len = s.Length;
            var sb = new StringBuilder(s);
            foreach (var item in shift)
            {
                var direction = item[0];//0 (for left shift) or 1 (for right shift).
                var amount = item[1] % len;// amounti is the amount by which string s is to be shifted.
                if (direction == 0)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        var sub = sb[0];
                        sb.Remove(0, 1);
                        sb.Append(sub.ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < amount; i++)
                    {
                        var sub = sb[sb.Length - 1];
                        sb.Remove(sb.Length - 1, 1);
                        sb.Insert(0, sub.ToString());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
