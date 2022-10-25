using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _670
    {
        public int MaximumSwap(int num)
        {
            var words = new StringBuilder(num.ToString());
            var maxjValue = '0';
            var maxjIndex = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] <= '9')
                {
                    maxjValue = words[i];
                    for (int j = words.Length - 1; j >= i + 1; j--)
                    {
                        if (words[j] > maxjValue)
                        {
                            maxjIndex = j;
                            maxjValue = words[j];
                        }
                    }
                    //swap
                    if (maxjValue != words[i])
                    {
                        (words[i], words[maxjIndex]) = (words[maxjIndex], words[i]);
                        break;
                    }
                }
            }
            return Int32.Parse(words.ToString());
        }
    }
}
