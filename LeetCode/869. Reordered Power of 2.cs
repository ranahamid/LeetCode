using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _869
    {
        /// <summary>
        /// Runtime: 39 ms, faster than 100.00% of C# online submissions for Reordered Power of 2.
        /// Memory Usage: 29 MB, less than 33.33% of C# online submissions for Reordered Power of 2.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool ReorderedPowerOf2(int n)
        {
            var sF = GetFrequencyString(n.ToString());
            for (int i = 0; i < 30; i++)
            {
                var binVal = 1 << i;
                var binFreq = GetFrequencyString(binVal.ToString());
                if (IsValid(sF, binFreq))
                    return true;
            }
            return false;
        }
        public static bool IsValid(Dictionary<int, int> sF, Dictionary<int, int> binFreq)
        {
            if (sF.Count != binFreq.Count)
                return false;
            foreach (var item in sF)
            {
                if (binFreq.ContainsKey(item.Key))
                {
                    if (item.Value != binFreq[item.Key])
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static Dictionary<int, int> GetFrequencyString(string s)
        {
            var map = new Dictionary<int, int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (map.ContainsKey(s[index])) // if (map.ContainsKey(s[index]-48))
                {
                    map[s[index]]++; // map[s[index] - 48]++; 
                }
                else
                {
                    map[s[index]] = 1;// map[s[index] - 48] = 1;
                }
            }
            return map;
        }
    }
}
