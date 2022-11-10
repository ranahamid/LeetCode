using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class Two_Sum
    {
        /// <summary>
        /// int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
        // var result = TwoSum(nums, 11);
        // Console.WriteLine($"[{result[0]},{result[1]}]");
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> resultDic = new Dictionary<int, int>();
            var counter = 0;
            int[] result = { -1, -1 };
            foreach (var item in nums)
            {
                var targetRequired = target - item;
                if (resultDic.ContainsKey(targetRequired))
                {
                    var resultIndex = resultDic[targetRequired];
                    result[0] = resultIndex;
                    result[1] = counter;
                    return result;
                }
                else if (!resultDic.ContainsKey(item))
                {
                    resultDic.Add(item, counter);
                }
                counter++;
            }
            return result;
        }
    }
}
