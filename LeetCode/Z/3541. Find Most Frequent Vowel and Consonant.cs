using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3541
    {
    
            public int MaxFreqSum(string s)
            {
                var vowelDict = new Dictionary<char, int>();
                var ConsDict = new Dictionary<char, int>();
                var vowelSet = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
                foreach (var item in s)
                {
                    if (vowelSet.Contains(item))
                    {
                        if (vowelDict.ContainsKey(item))
                        {
                            vowelDict[item]++;
                        }
                        else
                        {
                            vowelDict[item] = 1;
                        }
                    }
                    else
                    {
                        if (ConsDict.ContainsKey(item))
                        {
                            ConsDict[item]++;
                        }
                        else
                        {
                            ConsDict[item] = 1;
                        }
                    }

                }
                var vowelCount = vowelDict.Count > 0 ? vowelDict.Values.Max() : 0;
                var constCount = ConsDict.Count > 0 ? ConsDict.Values.Max() : 0;
                return vowelCount + constCount;
            }
        }

}
