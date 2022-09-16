using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codechef
{
    internal class Chefland_Games
    {
        public static void Main1()
        {
            // your code goes here
            int intTemp = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < intTemp; index++)
            {
                string[] tokens = Console.ReadLine().Split();
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int c = int.Parse(tokens[2]);
                int d = int.Parse(tokens[3]);
                if (a == 0 && b == 0 && c == 0 && d == 0)
                    Console.WriteLine("IN");
                else
                    Console.WriteLine("OUT");
            }
        }
    }
}
