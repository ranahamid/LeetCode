using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codechef
{
    internal class The_Cheaper_Cab
    {
        public static void Chef1()
        {
            // your code goes here
            int intTemp = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < intTemp; index++)
            {
                string[] tokens = Console.ReadLine().Split();
                int a = int.Parse(tokens[0]);
                //Parse element 1
                int b = int.Parse(tokens[1]);
                if (a < b)
                    Console.WriteLine("FIRST");
                else if (b < a)
                    Console.WriteLine("SECOND");
                else
                    Console.WriteLine("ANY");
            }

        }
    }
}
