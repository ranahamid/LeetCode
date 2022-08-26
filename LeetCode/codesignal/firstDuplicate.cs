using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class firstDuplicate
    {
        int solution(int[] a)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (result.ContainsKey(a[i]))
                {
                    return a[i];
                }
                else
                {
                    result.Add(a[i], 1);
                }
            }
            return -1;
        }

    }
}
