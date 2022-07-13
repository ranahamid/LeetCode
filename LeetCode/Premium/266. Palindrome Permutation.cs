using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _266
    {
        public bool CanPermutePalindrome(string s)
        {
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic[s[i]] = 1;
                }
            }
            var counter = 0;
            foreach (var item in dic)
            {
                if (item.Value % 2 == 1)
                {
                    counter++;
                }
                if (counter > 1)
                    return false;
            }

            return true;
        }
    }
}
