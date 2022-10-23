using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_84
{
    internal class _2364
    {
        #region count 
        public long CountBadPairs(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] - i;
            }
            var freqList = GetFrequency(nums);
            long n = nums.Count();
            long result = n * (n - 1) / 2;
            foreach (var item in freqList)
            {
                n = item.Value;
                result -= n * (n - 1) / 2;
            }
            return result;
        }
        public static Dictionary<int, int> GetFrequency(int[] s)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map[s[i]] = 1;
                }
            }
            return map;
        }
        #endregion

        public long CountBadPairs_2(int[] nums)
        {
            var mp = new Dictionary<long, long>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (mp.ContainsKey(i - nums[i]))
                    mp[i - nums[i]]++;
                else
                    mp[i - nums[i]] = 1;
            }

            long pair = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                long diff = i - nums[i];
                mp[diff]--;
                pair += nums.Length - i - 1 - mp[diff];
            }
            return pair;
        }
    }
}
