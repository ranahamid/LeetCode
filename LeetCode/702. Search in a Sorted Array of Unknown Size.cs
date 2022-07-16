using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ArrayReader
    {
        public int Get(int index)
        {
            return 0;
        }
        public int Length() 
        {
            return 0;
        }
        public int CompareSub(int l, int r, int x, int y) 
        {
            return 0;
        }
    }
    internal class _702
    {
        /// <summary>
        /// Runtime: 239 ms, faster than 5.71% of C# online submissions for Search in a Sorted Array of Unknown Size.
        /// Memory Usage: 47 MB, less than 11.43% of C# online submissions for Search in a Sorted Array of Unknown Size.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(ArrayReader reader, int target)
        {
            int left = 0;
            int right = (int)Math.Pow(10, 4);//int.MaxValue;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var result = reader.Get(mid);
                if (result == target)
                {
                    return mid;
                }
                if (result == int.MaxValue || result > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
