using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _560
    {
        #region O(n^2)
        public int SubarraySum(int[] nums, int k)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                        counter++;
                }
            }
            return counter;
        }
        #endregion
        #region hash map
        public int SubarraySum_1(int[] nums, int k)
        {
            int counter = 0;
            var dic = new Dictionary<int, int>();
            dic.Add(0, 1);
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
                if (dic.ContainsKey(sum - k))
                    counter += dic[sum];
                if (dic.ContainsKey(sum))
                    dic[sum]++;
                else
                    dic[sum] = 1;
            }
            return counter;
        }
        #endregion
    }
}
