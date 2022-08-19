using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _659
    {
        /// <summary>
        /// Runtime: 176 ms, faster than 100.00% of C# online submissions for Split Array into Consecutive Subsequences.
        /// Memory Usage: 54.5 MB, less than 65.00% of C# online submissions for Split Array into Consecutive Subsequences.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool IsPossible(int[] nums)
        {
            Dictionary<int, int> subsequence = new Dictionary<int, int>();
            var frequency = GetFrequencyInt(nums);
            foreach (var num in nums)
            {
                //If the frequency of the current element num is 0, it means the num is already considered to be a part of a valid subsequence. Continue.
                if (!frequency.ContainsKey(num) || frequency[num] == 0)
                {
                    continue;
                }
                //Next, check if it is possible to add num to one of the existing subsequences.
                //For this, check if there is an entry with key as num - 1 in the subsequences map.
                //If there exists such an entry, it means we can add num to an existing subsequence.
                //Make the necessary changes in subsequences map to keep it consistent.
                if (subsequence.ContainsKey(num - 1) && subsequence[num - 1] > 0)
                {
                    subsequence[num - 1]--;
                    if (subsequence.ContainsKey(num))
                    {
                        subsequence[num]++;
                    }
                    else
                    {
                        subsequence[num] = 1;
                    }
                }
                //If no such subsequence exists, we need to create a new subsequence with num as the first element.
                //For this, we need to check if num + 1 and num + 2 exist or not.
                //If they don't, no valid subsequence is possible with num as the starting element.
                //Return false. Otherwise, make the necessary changes in subsequences map to keep it consistent.
                else if (frequency.ContainsKey(num + 1) && frequency[num + 1] > 0 && frequency.ContainsKey(num + 2) && frequency[num + 2] > 0)
                {
                    frequency[num + 1]--;
                    frequency[num + 2]--;
                    if (subsequence.ContainsKey(num + 2))
                    {
                        subsequence[num + 2]++;
                    }
                    else
                    {
                        subsequence[num + 2] = 1;
                    }
                }
                //otherwise, false
                else
                {
                    return false;
                }
                //decrement frequency
                frequency[num]--;
            }
            return true;
        }
        public static Dictionary<int, int> GetFrequencyInt(int[] s)
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
    }
}
