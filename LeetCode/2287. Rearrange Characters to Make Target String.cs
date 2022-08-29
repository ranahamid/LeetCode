using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2287
    {
        /// <summary>
        /// Runtime: 117 ms, faster than 16.22% of C# online submissions for Rearrange Characters to Make Target String.
        /// Memory Usage: 34.9 MB, less than 89.19% of C# online submissions for Rearrange Characters to Make Target String.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int RearrangeCharacters(string s, string target)
        {
            var targetSf = GetFrequencyString(target);
            var sF = GetFrequencyString(s);
            var counter = 0;
            var isFound = true;
            while (true)
            {
                foreach (var item in targetSf)
                {
                    if (sF.ContainsKey(item.Key))
                    {
                        if (sF[item.Key] >= item.Value)
                        {
                            sF[item.Key] -= item.Value;
                            if (sF[item.Key] == 0)
                                sF.Remove(item.Key);
                        }
                        else
                        {
                            isFound = false;
                            break;
                        }
                    }
                    else
                    {
                        isFound = false;
                        break;
                    }
                }
                if (!isFound)
                    break;
                counter++;
            }
            return counter;
        }
        public static Dictionary<char, int> GetFrequencyString(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (map.ContainsKey(s[index]))
                {
                    map[s[index]]++;
                }
                else
                {
                    map[s[index]] = 1;
                }
            }
            return map;
        }
    }
}
