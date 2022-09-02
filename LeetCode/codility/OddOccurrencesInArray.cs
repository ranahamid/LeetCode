using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codility
{
    internal class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var dic = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (dic.ContainsKey(item))
                {
                    dic.Remove(item);
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            foreach (var item in dic)
            {
                return item.Key;
            }
            return 0;
        }
    }
}
