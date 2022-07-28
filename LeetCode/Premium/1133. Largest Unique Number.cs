using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1133
    {
        /// <summary>
        /// Runtime: 149 ms, faster than 25.81% of C# online submissions for Largest Unique Number.
        /// Memory Usage: 37.8 MB, less than 48.39% of C# online submissions for Largest Unique Number.
      /// </summary>
      /// <param name="nums"></param>
      /// <returns></returns>
        public int LargestUniqueNumber(int[] nums)
            {
                var dic = new SortedList<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dic.ContainsKey(nums[i]))
                    {
                        dic[nums[i]]++;
                    }
                    else
                    {
                        dic[nums[i]] = 1;
                    }
                }
                var data = dic.Reverse();
                foreach (var item in data)
                {

                    if (item.Value == 1)
                    {
                        return item.Key;
                    }
                }
                return -1;
            }

        
    }
}
