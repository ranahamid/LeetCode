using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3146
    {
        public int FindPermutationDifference(string s, string t)
        {
            var sCharArray = s.ToCharArray();
            var tCharArray = t.ToCharArray();
            var sum = 0;
            for (int i = 0; i < sCharArray.Length; i++)
            {
                var tIndex = Array.IndexOf(tCharArray, sCharArray[i]);
                sum += Math.Abs(i - tIndex);
            }
            return sum;
        }
    }
}
