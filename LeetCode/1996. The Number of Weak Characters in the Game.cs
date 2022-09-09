using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1996
    {
        public int NumberOfWeakCharacters(int[][] properties)
        {
            int ans = 0, minVal = Int32.MinValue;
            properties = properties.OrderBy(x => x[0]).ThenByDescending(x => x[1]).ToArray();           
            for (int i = properties.Length - 1; i >= 0; i--)
            {
                var item = properties[i];
                if (item[1] < minVal)
                {
                    ans++;
                }
                else
                {
                    minVal = item[1];
                }
            }
            return ans;
        }
    }
}
