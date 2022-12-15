using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2099
    {
        public int[] MaxSubsequence(int[] nums, int k)
        {
            int[] unsortedArray2 = new int[nums.Length];
            nums.CopyTo(unsortedArray2, 0);
            Array.Sort(unsortedArray2, (left, right) => right.CompareTo(left));
            var list = unsortedArray2.Take(k).ToList(); 
            var result = new int[k];
            int i = 0;
            foreach (var n in nums)
            {
                if (list.Contains(n))
                {
                    result[i++] = n;
                    list.Remove(n);
                }
                if (i == k)
                    break;
            }
            return result;
        }
    }
}
