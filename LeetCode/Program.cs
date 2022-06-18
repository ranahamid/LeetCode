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
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            ListNode five = new ListNode(5);
            ListNode four = new ListNode(4, five);
            ListNode three = new ListNode(3, four);
            ListNode two = new ListNode(2, three);
            ListNode one = new ListNode(1,two); 
             
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    
    }
 
}
