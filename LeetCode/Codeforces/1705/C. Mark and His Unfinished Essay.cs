using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        /// <summary>
        /// https://codeforces.com/contest/1705/problem/C
        /// MEMORY LIMIT Exceed
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int intTemp = Convert.ToInt32(Console.ReadLine());
            var ind = 0;
            string test = "";
            int a = 0, b = 0, n, c, r;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < intTemp; index++)
            {
                //Read line, and split it by whitespace into an array of strings
                string[] tokens = Console.ReadLine().Split();
                //Parse element 0
                n = int.Parse(tokens[0]);
                c = int.Parse(tokens[1]);
                r = int.Parse(tokens[1]);

                string s = Console.ReadLine();
                sb = new StringBuilder(s);
                s = string.Empty;

                for (int i = 0; i < c; i++)
                {
                    string[] numbers = Console.ReadLine().Split();
                    a = int.Parse(numbers[0]);
                    b = int.Parse(numbers[1]);

                    test = sb.ToString(a - 1, b - a + 1);
                    sb.Append(test);
                }

                for (int i = 0; i < r; i++)
                {
                    ind = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sb[ind - 1]);
                }
                sb.Clear();
            }
        }
    }
}
