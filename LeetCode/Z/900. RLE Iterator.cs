using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime 186 ms Beats 53.70% Memory 39.6 MB Beats 87.4%
    /// </summary>
    public class RLEIterator
    {
        int index;
        int[] A;

        public RLEIterator(int[] encoding)
        {
            A = encoding;
            index = 0;
        }

        public int Next(int n)
        {
            while (index < A.Length && n > A[index])
            {
                n -= A[index];
                index += 2;
            }
            if (index >= A.Length)
            {
                return -1;
            }
            A[index] -= n;
            return A[index + 1];
        }
    }

    /**
     * Your RLEIterator object will be instantiated and called as such:
     * RLEIterator obj = new RLEIterator(encoding);
     * int param_1 = obj.Next(n);
     */
}
