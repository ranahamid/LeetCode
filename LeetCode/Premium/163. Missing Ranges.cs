using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _163
    {
        #region solution
        /// <summary>
        /// Runtime: 189 ms, faster than 71.76% of C# online submissions for Missing Ranges.
        /// Memory Usage: 41.7 MB, less than 55.88% of C# online submissions for Missing Ranges.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            var res = new List<string>();
            var prev = lower - 1;
            for (int i = 0; i <= nums.Length; i++)
            {
                var current = i < nums.Length ? nums[i] : upper + 1;
                if (prev + 1 <= current - 1)
                {
                    res.Add(FormatMissingRange(prev + 1, current - 1));
                }
                prev = current;
            }
            return res;
        }
        public static string FormatMissingRange(int lower, int upper)
        {
            if (lower == upper)
            {
                return lower.ToString();
            }
            return string.Format($"{lower}->{upper}");
        }
        #endregion


        /// <summary>
        /// Runtime: 268 ms, faster than 18.24% of C# online submissions for Missing Ranges.
        /// Memory Usage: 41.8 MB, less than 47.65% of C# online submissions for Missing Ranges.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public IList<string> FindMissingRanges_1(int[] nums, int lower, int upper)
        {
            List<string> result = new List<string>();
            if (nums.Length == 0)
            {
                var range = upper - lower;
                if (range >= 1)
                {
                    var a = lower;
                    var b = upper;
                    result.Add($"{a}->{b}");
                }
                else
                {
                    result.Add(lower.ToString());
                }
                return result;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    if (lower != nums[0])
                    {
                        var range = nums[0] - lower;
                        if (range > 1)
                        {
                            var a = lower;
                            var b = nums[0] - 1;
                            result.Add($"{a}->{b}");
                        }
                        else
                        {
                            result.Add(lower.ToString());
                        }
                    }
                }
                else
                {
                    if (nums[i] != nums[i - 1] + 1)
                    {
                        var range = nums[i] - nums[i - 1];
                        if (range > 2)
                        {
                            var a = nums[i - 1] + 1;
                            var b = nums[i] - 1;
                            result.Add($"{a}->{b}");
                        }
                        else
                        {
                            result.Add((nums[i - 1] + 1).ToString());
                        }
                    }
                }
            }
            if (nums[nums.Length - 1] != upper)
            {
                var range = upper - nums[nums.Length - 1];
                if (range > 1)
                {
                    var a = nums[nums.Length - 1] + 1;
                    var b = upper;
                    result.Add($"{a}->{b}");
                }
                else
                {
                    result.Add(upper.ToString());
                }
            }
            return result;
        }
    }
}
