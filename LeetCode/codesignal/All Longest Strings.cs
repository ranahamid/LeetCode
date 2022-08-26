using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class All_Longest_Strings
    {
        string[] solution(string[] inputArray)
        {
            var list =new List<string>();
            var maxLen = 0;
            foreach(var item in inputArray)
            {
                maxLen = Math.Max(item.Length, maxLen);
            }
            foreach(var item in inputArray)
            {
                if (item.Length == maxLen)
                {
                    list.Add(item);
                }
            }
            return list.ToArray();
        }

    }
}
