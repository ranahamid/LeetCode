using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codechef
{
    internal class Nearest_Exit
    {
        public static void Main1()
        {
            // your code goes here
            int intTemp = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < intTemp; index++)
            {

                int a = Convert.ToInt32(Console.ReadLine());
                if (a >= 1 && a <= 50)
                    Console.WriteLine("LEFT");
                else
                    Console.WriteLine("RIGHT");
            }
        }
    }
}
