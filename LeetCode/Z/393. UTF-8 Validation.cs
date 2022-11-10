using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _393
    {
        public bool ValidUtf8(int[] data)
        {
            int mask = 1 << 7;
            int mask1 = 1 << 7;
            int mask2 = 1 << 6;

            int bytesToProcess = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (bytesToProcess == 0)
                {
                    mask = 1 << 7;
                    while ((data[i] & mask) != 0)
                    {
                        bytesToProcess++;
                        mask >>= 1;
                    }
                    if (bytesToProcess == 0)
                        continue;
                    if (bytesToProcess > 4 || bytesToProcess == 1)
                        return false;
                }
                else
                {
                    var a = data[i] & mask1;
                    var b = data[i] & mask2;
                    if (!(a != 0 && b == 0))
                        return false;
                }
                bytesToProcess--;
            }
            return bytesToProcess == 0;
        }
    }
}
