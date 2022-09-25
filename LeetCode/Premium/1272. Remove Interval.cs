using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    /// <summary>
    /// DAY - 100
    /// 887 total solved
    /// </summary>
    internal class _1272
    {
        /// <summary>
        /// Runtime: 357 ms, faster than 73.33% of C# online submissions for Remove Interval.
        /// Memory Usage: 50.5 MB, less than 86.67% of C# online submissions for Remove Interval.
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="toBeRemoved"></param>
        /// <returns></returns>
        public IList<IList<int>> RemoveInterval(int[][] intervals, int[] toBeRemoved)
        {
            List<IList<int>> result = new List<IList<int>>();
            foreach (var interval in intervals)
            {
                if (interval[0] > toBeRemoved[1] || interval[1] < toBeRemoved[0])
                {
                    result.Add(new List<int>{
                    interval[0],interval[1]
                });
                }
                else
                {
                    if (interval[0] < toBeRemoved[0])
                    {

                        result.Add(new List<int>{
                    interval[0],toBeRemoved[0]
                });
                    }

                    if (interval[1] > toBeRemoved[1])
                    {

                        result.Add(new List<int>{
                    toBeRemoved[1],interval[1]
                });
                    }

                }
            }
            return result;
        }
    }
}
