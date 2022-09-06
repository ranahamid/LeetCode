using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class Find_all_n_digit_binary_numbers_without_any_consecutive_1_s
    {
        //https://www.techiedelight.com/find-n-digit-binary-strings-without-consecutive-1s/
        int counter = 1;
        public void BuildOnes(int n)
        {
            PrintOnes(n, "0", 0);
        }
        public void PrintOnes(int n, string output, int lastDigit)
        {
            if (n == 0)
            {
                Console.WriteLine(counter++ + ":" + output);
                return;
            }
            PrintOnes(n - 1, output + "0", 0);
            if (lastDigit == 0)
                PrintOnes(n - 1, output + "1", 1);
        }
    }
}
