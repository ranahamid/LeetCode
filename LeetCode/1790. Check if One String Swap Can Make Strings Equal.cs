using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1790
    {
        //    Runtime: 157 ms, faster than 5.33% of C# online submissions for Check if One String Swap Can Make Strings Equal.
        //Memory Usage: 36.7 MB, less than 94.67% of C# online submissions for Check if One String Swap Can Make Strings Equal.

        public static bool AreAlmostEqual(string s1, string s2)
        {
            var s1Array = s1.ToCharArray();
            Array.Sort(s1Array);
            var s2Array = s2.ToCharArray();
            Array.Sort(s2Array);
            if (new string(s1Array) != new string(s2Array)) return false;

            var counter = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    counter++;
            }
            if (counter == 0 || counter == 2)
                return true;
            return false;
        }
        #region method2
        public static Dictionary<char, int> GetCharCount(string s1)
        {
            Dictionary<char, int> mapS1 = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (mapS1.ContainsKey(s1[i]))
                {
                    mapS1[s1[i]]++;
                }
                else
                {
                    mapS1[s1[i]] = 1;
                }
            }
            return mapS1;
        }
        public bool AreAlmostEqual_2(string s1, string s2)
        {
            Dictionary<char, int> mapS1 = GetCharCount(s1);
            Dictionary<char, int> mapS2 = GetCharCount(s2);
            foreach (var item in mapS1)
            {
                if (mapS2.ContainsKey(item.Key))
                {
                    var s2Val = mapS2[item.Key];
                    if (s2Val != item.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            foreach (var item in mapS2)
            {
                if (mapS1.ContainsKey(item.Key))
                {
                    var s1Val = mapS1[item.Key];
                    if (s1Val != item.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            var counter = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    counter++;
            }
            if (counter == 0 || counter == 2)
                return true;
            return false;
        }
        #endregion

    }
}
