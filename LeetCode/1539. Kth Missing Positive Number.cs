using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1539
    {
        #region binary search
        /// <summary>
        /// Runtime: 135 ms, faster than 48.07% of C# online submissions for Kth Missing Positive Number.
        /// Memory Usage: 38 MB, less than 29.28% of C# online submissions for Kth Missing Positive Number.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthPositive(int[] arr, int k)
        {
            var left = 0;
            var right = arr.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (arr[mid] - mid - 1 < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left + k;
        }
        #endregion

        #region self

        /// <summary>
        /// Runtime: 155 ms, faster than 25.41% of C# online submissions for Kth Missing Positive Number.
        /// Memory Usage: 37.9 MB, less than 36.46% of C# online submissions for Kth Missing Positive Number.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthPositive_1(int[] arr, int k)
        {
            var missingNumbers = new List<int>();
            var counter = 0;
            var kthCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var val = arr[i];//2
                counter++;
                if (counter != val)
                {
                    while (counter != val)
                    {
                        missingNumbers.Add(counter);
                        counter++;
                        if (missingNumbers.Count == k)
                        {
                            return missingNumbers[kthCounter];
                        }
                        kthCounter++;
                    }
                    if (missingNumbers.Count == k)
                    {
                        return missingNumbers[kthCounter];
                    }
                }
            }
            if (missingNumbers.Count() > 0)
            {
                var missingLast = missingNumbers.LastOrDefault();
                var retNum = missingLast + k - missingNumbers.Count();
                if (arr.Contains(missingLast + 1))
                {
                    while (arr.Contains(missingLast + 1))
                    {
                        missingLast++;
                    }
                    var last = arr.LastOrDefault();
                    return last + k - kthCounter;
                }
                else
                {
                    return retNum + 1;
                }
            }
            else
            {
                return arr.LastOrDefault() + k;
            }
        }
        #endregion
    }
}
