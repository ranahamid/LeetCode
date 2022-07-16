using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1533
    {       /// <summary>
            /// Runtime: 487 ms, faster than 25.00% of C# online submissions for Find the Index of the Large Integer.
            /// Memory Usage: 61.5 MB, less than 31.25% of C# online submissions for Find the Index of the Large Integer.
            /// </summary>
            /// <param name="reader"></param>
            /// <returns></returns>
        public int GetIndex(ArrayReader reader)
        {
            int start = 0;
            int length = reader.Length();
            int end = length - 1;//5* (int)Math.Pow(10,5);//int.MaxValue;

            while (start < end)
            {
                var mid = start + (end - start) / 2;
                int total = end - start + 1;
                var result = 0;
                if (total % 2 == 0)
                    result = reader.CompareSub(start, mid, mid + 1, end);
                else
                    result = reader.CompareSub(start, mid - 1, mid + 1, end);

                if (result == 0)
                {
                    return mid;
                }
                if (result == 1)
                {
                    end = mid;//mid- 1
                }
                if (result == -1)
                {
                    start = mid + 1;
                }
            }
            return start;
        }

    }
}
