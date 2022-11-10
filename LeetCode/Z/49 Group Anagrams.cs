using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _49_Group_Anagrams
    {
        //Runtime: 242 ms, faster than 65.43% of C# online submissions for Group Anagrams.
        public static List<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                var chars = item.ToCharArray();
                Array.Sort(chars);
                var keyVal = new string(chars);
                if (dc.ContainsKey(keyVal))
                {
                    var currentVal = dc[keyVal];
                    currentVal.Add(item);
                    dc[keyVal] = currentVal;
                }
                else
                {
                    dc[keyVal] = new List<string>() { item };
                }
            }
            foreach (var item in dc.Values)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
