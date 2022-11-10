using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _944
    {
        public int MinDeletionSize(string[] strs)
        {
            var counter = 0;
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    var a = strs[j][i];
                    var b = strs[j + 1][i];
                    if (a > b)
                    {
                        counter++;
                        break;
                    }
                }
            }
            return counter;
        }
    }
}
