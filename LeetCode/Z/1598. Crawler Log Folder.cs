using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1598
    {
        public static int MinOperations(string[] logs)
        {
            var counter = 0;
            foreach (var item in logs)
            {
                if (item == "./")
                    continue;
                if (item == "../")
                {
                    if (counter > 0)
                        counter--;
                }
                else
                    counter++;
            }
            return counter < 0 ? 0 : counter;
        }
    }
}
