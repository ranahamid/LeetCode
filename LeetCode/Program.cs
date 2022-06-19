using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            var res = SearchRange(nums, 8);
            Console.WriteLine($"{res[0]},{res[1]}");
            Console.ReadKey();
        }
        
    }
}
