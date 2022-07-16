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
            int[][] nums = new int[3][]
            {
                new int[2] { 3,50 },
                new int[2] { 7,10 },
                new int[2] { 12,25 },
            };

            int[][] nums1 = new int[2][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 1 },
            };


            #region node

            //ListNode eig = new ListNode(3);
            //TreeNode sev = new TreeNode(0);
            //TreeNode six = new TreeNode(3);
            //TreeNode five = new TreeNode();
            //TreeNode list2 = new TreeNode(2, five, six);

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
            var resW1 = new char[] { 'z', 'a', 'b', 'c', 'x', 'x', 'x' };
            var resW2 = new string[]
            {
                "ab","a"
            };
            var res1 = new int[] { -1, 0, 3, 5, 9, 12 };
            var res2 = new int[] { 1, 2, 9 };
            var res3 = new int[] { 1, 1000,2};
            Console.WriteLine(BinaryGap(8));

            Console.ReadKey();
        }
        //public class TreeNode
        //{
        //    public int val;
        //    public TreeNode start ;
        //    public TreeNode end ;
        //    public TreeNode(int val = 0, TreeNode start  = null, TreeNode end  = null)
        //    {
        //        this.val = val;
        //        this.start  = start ;
        //        this.end  = end ;
        //    }
        //}






        



    }


}