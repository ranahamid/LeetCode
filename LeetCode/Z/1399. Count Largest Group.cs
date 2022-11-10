using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1399
    {
        public int CountLargestGroup(int n)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 1; i <= n; i++)
            {
                var sum = GetDigitSum(i);
                if (dic.ContainsKey(sum))
                {
                    dic[sum]++;
                }
                else
                {
                    dic[sum] = 1;
                }
            }
            var values = dic.Select(x => x.Value).Max();
            var res = dic.Count(x => x.Value == values);
            return res;
        }

        public static int GetDigitSum(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
