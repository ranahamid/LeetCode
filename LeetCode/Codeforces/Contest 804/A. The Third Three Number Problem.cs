using System;
namespace LeetCode
{
    internal class Program
    {
        /// <summary>
        /// https://codeforces.com/contest/1699/problem/A
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int intTemp = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < intTemp; index++)
            {
                var n = Convert.ToInt32(Console.ReadLine()); 
                if (n % 2 == 1)
                {
                    Console.WriteLine(-1); 
                }
                else
                {
                    int i=0, j=0;
                    int k = n >> 1;
                    Console.WriteLine($"{i} {j} {k}");
                } 
            }
        }
    }
}
 