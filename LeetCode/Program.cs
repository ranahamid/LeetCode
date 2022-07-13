﻿using System;
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
            //TreeNode sev = new TreeNode(4);
            //TreeNode six = new TreeNode(3);
            //TreeNode five = new TreeNode(2,sev);
            //TreeNode list2 = new TreeNode(1, five, six);

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
           "this","is","a","long","run","sentence","is","fun","day","today","sunny","weather","is","a","day","tuesday","this","sentence","running","rainy"
            };
            var res1 = new int[] { 3, 2, 3 };
            var res2 = new int[] { 1, 2, 9 };
            var res3 = new int[] { 1, 4, 5, 2, 3 };
            // var res3 = new int[] {3,8,-10,23,19,-4,-14,27};
            //Solution s = new Solution();
            //var rd=s.LevelOrderPrint(res1);
            //Console.WriteLine(IsSameTree(rd,rd));

            Console.WriteLine(LargestSubarray(res3, 3));
            Console.ReadKey();
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


























    }


}