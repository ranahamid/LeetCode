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
            int[][] nums = new int[2][]{
                new int[2]{1,1},
                new int[2]{0,0}, 
            };

            int[][] nums1 = new int[2][]{
                new int[2]{0,1},
                new int[2]{1,1},
            };
            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(6, six);
            //ListNode list2 = new ListNode(5, five);


            //ListNode fifteen = new ListNode(0);
            //ListNode fourtenn = new ListNode(0, fifteen);
            //ListNode thirteen = new ListNode(0, fourtenn);
            //ListNode twelve = new ListNode(0, thirteen);
            //ListNode eleven = new ListNode(0, twelve);
            //ListNode ten = new ListNode(0, eleven);
            //ListNode nine = new ListNode(1, ten);
            //ListNode eight = new ListNode(1, nine);
            //ListNode seven = new ListNode(1, eight);
            //ListNode six = new ListNode(0, seven);
            //ListNode five = new ListNode(0, six);
            //ListNode four = new ListNode(1, five);
            //ListNode three = new ListNode(0, four);
            //ListNode two = new ListNode(0, three);
            //ListNode list1 = new ListNode(1, two);


            //ListNode list1 = new ListNode(5);

            //Console.Write(MyAtoi2("words and 987"));
            //Console.Write(MyAtoi2("-91283472332"));
            //Console.Write(MyAtoi("4193 with words"));

            var res = new string[] { "pay", "attention", "practice", "attend" };
            var res1 = new int[] { 1, 5, 2, 4, 1 };

            var paths = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                  new List<string>() { "New York","Lima" },
                    new List<string>() { "Lima","Sao Paulo" },
            };


            Console.WriteLine(AreOccurrencesEqual("wzkpzzwzpzkwkpkppzkppkpkwwkzzzwwpwwk"));

            Console.WriteLine("Hello");
            Console.ReadKey();
        }



     
















































































    }


}
