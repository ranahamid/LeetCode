using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _916
    {
        /// <summary>
        /// Runtime: 596 ms, faster than 33.33% of C# online submissions for Word Subsets.
        /// Memory Usage: 51.1 MB, less than 100.00% of C# online submissions for Word Subsets.
        /// </summary>
        /// <param name="words1"></param>
        /// <param name="words2"></param>
        /// <returns></returns>
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            var result = new List<string>();
            bool isFound; 
            Dictionary<char, int> dic1;
            Dictionary<char, int> final = new Dictionary<char, int>();
            foreach (var item2 in words2)
            {
                var res = GetCurrentCount(item2);
                foreach (var item in res)
                {
                    if (final.ContainsKey(item.Key))
                    {
                        final[item.Key] = Math.Max(item.Value, final[item.Key]);
                    }
                    else
                    {
                        final[item.Key] = item.Value;
                    }
                }
            }


            foreach (var item in words1)
            {
                dic1 = GetCurrentCount(item);
                isFound = true;

                foreach (var dic2Item in final)
                {
                    if (dic1.ContainsKey(dic2Item.Key))
                    {

                        if (dic2Item.Value > dic1[dic2Item.Key])
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
                if (isFound)
                    result.Add(item);

            }
            return result;
        }


        public static Dictionary<char, int> GetCurrentCount(string word)
        {
            var map = new Dictionary<char, int>();
            foreach (var ch in word)
            {
                if (map.ContainsKey(ch))
                {
                    map[ch]++;
                }
                else
                {
                    map[ch] = 1;
                }
            }
            return map;
        }

    }
}
