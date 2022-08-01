using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _383
    {
        /// <summary>
        /// Runtime: 137 ms, faster than 43.69% of C# online submissions for Ransom Note.
        /// Memory Usage: 40.1 MB, less than 82.08% of C# online submissions for Ransom Note.
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineDic = GetCharFrequency(magazine);
            var ransomDic = GetCharFrequency(ransomNote);
            foreach (var item in ransomDic)
            {
                if (magazineDic.ContainsKey(item.Key))
                {
                    if (item.Value > magazineDic[item.Key])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static Dictionary<char, int> GetCharFrequency(string word)
        {
            var charFrequency = new Dictionary<char, int>();
            foreach (var item in word)
            {
                if (charFrequency.ContainsKey(item))
                {
                    charFrequency[item]++;
                }
                else
                {
                    charFrequency[item] = 1;
                }
            }
            return charFrequency;
        }
    }
}
