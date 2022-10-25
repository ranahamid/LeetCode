using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _921
    {
        public int MinAddToMakeValid(string s)
        {
            int open = 0;
            int result = 0;
            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    open++;
                }
                else
                {
                    if (open > 0)
                    {
                        open--;
                    }
                    else
                    {
                        result++;
                    }
                }
            }
            return result + open;
        }
    }
}
