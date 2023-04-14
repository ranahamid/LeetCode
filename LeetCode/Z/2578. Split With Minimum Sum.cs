using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class _2578
    {
        public int SplitNum(int num)
        {
            var charArray = num.ToString().ToCharArray().OrderBy(x => x).ToArray();
            int n = charArray.Length;

            int n1 = 0, n2 = 0;
            var first = true;
            // foreach(var x in charArray)
            for (int i = 0; i < charArray.Count(); i++)
            {
                if (first)
                {
                    n1 = n1 * 10 + charArray[i] - 48;
                }
                else
                {
                    n2 = n2 * 10 + charArray[i] - 48;
                }
                first = !first;
            }
            return n1 + n2;

        }
    }
}
