using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_291
{
    internal class _2259_Remove_Digit_From_Number_to_Maximize_Result
    {
        public void display()
        {
            //Console.WriteLine(RemoveDigit("2998589353917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471", '3'));
            Console.WriteLine(RemoveDigit("1231", '1'));
        }
        public static string RemoveDigit(string number, char digit)
        {
            long maxNumber = 0;
            var chars = number.ToCharArray();
            var len = chars.Where(x => x == digit).Count();
            var resultMax = new List<string>();

            for (int i = 1; i <= len; i++)
            {
                StringBuilder strBuilder = new StringBuilder(number);

                var firstPlace = GetNthIndex(number, digit, i);
                strBuilder.Remove(firstPlace, 1);
                resultMax.Add(strBuilder.ToString());
            }
            //find from result max
            var sorted = resultMax.Select(BigInteger.Parse).OrderBy(e => e).Select(e => e.ToString()).ToArray();

            return sorted.LastOrDefault();
        }
        public static int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


    }
}
