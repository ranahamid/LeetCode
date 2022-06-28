using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{


    internal class Program
    {
        static void Main(string[] args)
        {
              

            int[][] nums = new int[4][]
            {
                new int[4] { 1, 1, 0, 0 },
                new int[4] { 1, 0, 0, 1 },
                new int[4] { 0, 1, 1, 1 },
                new int[4] { 1, 0, 1, 0 },
            };

            int[][] nums1 = new int[2][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 1 },
            };


            #region node

           // ListNode eig = new ListNode(3);
            //ListNode sev = new ListNode(3, eig);
            //ListNode six = new ListNode(2, sev);
            //ListNode five = new ListNode(1, six);
            //ListNode list2 = new ListNode(1, five);

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

            #endregion

            var paths = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                new List<string>() { "New York", "Lima" },
                new List<string>() { "Lima", "Sao Paulo" },
            };
            var res = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            var res1 = new int[] { 3, 1 ,1};
            var res2 = new int[] { 2, 3 ,2};
            var res3 = new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            // Console.WriteLine(HeightChecker(res1));
           Console.WriteLine(SortByBits(  res3));
            Console.ReadKey();
        }



       




















































































    }



}