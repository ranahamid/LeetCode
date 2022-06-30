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
              

            int[][] nums = new int[3][]
            {
                new int[3] { 3,7,8 },
                new int[3] { 9,11,13 },
                new int[3] { 15,16,17 }, 
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
            var resW1 = new string[] { "a","ab"};
            var resW2 = new string[] { "Hello","Alaska","Dad","Peace"};
            var res1 = new int[] { 2,3,1,3,2,4,6,7,9,2,19};
            var res2 = new int[] { 2,1,4,3,9,6};
            var res3 = new int[] {1,0,0,8,6};
           // var res3 = new int[] {3,8,-10,23,19,-4,-14,27};
            // Console.WriteLine(HeightChecker(res1));
           Console.WriteLine(RelativeSortArray( res1,res2));
            Console.ReadKey();
        }
     
        
 


















    }



}