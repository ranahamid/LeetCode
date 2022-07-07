using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeetCode
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[4][]
            {
                new int[2] { 5,10 },
                new int[2] { 2,5 },
                new int[2] { 4,7 },
                new int[2] { 3,9 },
            };

            int[][] nums1 = new int[2][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 1 },
            };


            #region node

            //ListNode eig = new ListNode(3);
            //ListNode sev = new ListNode(3, eig);
            //TreeNode six = new TreeNode(3 );
            //TreeNode five = new TreeNode(1 );
            //TreeNode list2 = new TreeNode(2, five,six);

            //ListNode fifteen = new ListNode(0);
            //ListNode fourtenn = new ListNode(0, fifteen);

            //ListNode thirteen = new ListNode(0);
            //ListNode twelve = new ListNode(5, thirteen);
            //ListNode eleven = new ListNode(5, twelve);
            //ListNode ten = new ListNode(2, eleven);
            //ListNode nine = new ListNode(4, ten);
            //ListNode eight = new ListNode(9, nine);
            //ListNode seven = new ListNode(7, eight);
            //ListNode six = new ListNode(1, seven);
            //ListNode five = new ListNode(8, six);
            //ListNode four = new ListNode(6, five);
            //ListNode three = new ListNode(2, four);
            //ListNode two = new ListNode(0, three);
            //ListNode list1 = new ListNode(3, two);

            #endregion

            var paths = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                new List<string>() { "New York", "Lima" },
                new List<string>() { "Lima", "Sao Paulo" },
            };
            var resW1 = new string[] { "a", "ab" };
            var resW2 = new string[]
            {
             "apple","pen"
            };
            var res1 = new int[] { 1, 7, 4, 9, 2, 5 };
            var res2 = new int[] { -4, -3, 6, 10, 20, 30 };
            var res3 = new int[] { 6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6, 10, 8, 2, 3, 4 };
            // var res3 = new int[] {3,8,-10,23,19,-4,-14,27};
            Console.WriteLine(TrimMean(res3));
            //Console.WriteLine(ReformatDate("20th Oct 2052")); 
            Console.ReadKey();
        }

        public static double TrimMean(int[] arr)
        {
            var totalSum=arr.Sum();
            var removeNumbs = arr.Length / 20;
            Array.Sort(arr);
            for(int i = 0; i < removeNumbs; i++)
            {
                totalSum = totalSum - arr[i];
                totalSum = totalSum - arr[arr.Length- i-1];
                 
            }
            var avg=(double)(totalSum/( (double)(arr.Length - 2 * removeNumbs)));
            return avg;
        }
    }
}