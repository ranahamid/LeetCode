using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2496
    {/// <summary>
     /// Runtime 91 ms Beats 86.36% Memory 38.4 MB Beats 20%
     /// </summary>
     /// <param name="strs"></param>
     /// <returns></returns>
        public int MaximumValue(string[] strs)
        {
            var max = 0;
            foreach (var item in strs)
            {


                var current = 0;
                if (Int32.TryParse(item, out int n))
                {
                    current = Math.Max(current, n);
                }
                else
                {
                    current = item.Length;
                }
                max = Math.Max(max, current);
            }
            return max;
        }
    }
}
