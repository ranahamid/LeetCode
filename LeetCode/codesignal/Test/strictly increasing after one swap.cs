using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal.Test
{
    internal class strictly_increasing_after_one_swap
    {
        bool solution(int[] numbers)
        {
            var inc = 0;
            var index = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] >= numbers[i + 1])
                {
                    inc++;
                    index = i;

                    if (inc > 1)
                        break;
                }
            }
            if (inc > 1)
                return false;
            if (inc == 0)
                return true;

            int a = Int32.MinValue;
            int b = numbers[index];
            int c = numbers[index + 1];
            int d = Int32.MaxValue;
            if (index > 0)
                a = numbers[index - 1];
            if (index < (numbers.Length - 2))
            {
                d = numbers[index + 2];
            }

            var b_s = new StringBuilder(b.ToString());
            var c_s = new StringBuilder(c.ToString());

            for (int i = 0; i < b_s.Length; i++)
                for (int j = i + 1; j < b_s.Length; j++)
                {
                    (b_s[i], b_s[j]) = (b_s[j], b_s[i]);
                    int newB = Int32.Parse(b_s.ToString());
                    if (newB > a && c > newB)
                        return true;
                    (b_s[i], b_s[j]) = (b_s[j], b_s[i]);
                }

            for (int i = 0; i < c_s.Length; i++)
                for (int j = i + 1; j < c_s.Length; j++)
                {
                    (c_s[i], c_s[j]) = (c_s[j], c_s[i]);
                    int newC = Int32.Parse(c_s.ToString());
                    if (newC > b && d > newC)
                        return true;
                    (c_s[i], c_s[j]) = (c_s[j], c_s[i]);
                }
            return false;
        }

    }
}
