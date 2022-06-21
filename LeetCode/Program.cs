﻿using System;
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
            //int[][] nums = new int[3][]{
            //    new int[4]{1,3, 5,7},
            //    new int[4]{10,11,16,20},
            //    new int[4]{23,30,34,60}
            //};
            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(6, six);
            //ListNode list2 = new ListNode(5, five);


            //ListNode three = new ListNode(3);
            //ListNode two = new ListNode(4, three);
            //ListNode list1 = new ListNode(2, two);


            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(2, six);
            //ListNode list2 = new ListNode(1, five);


            //ListNode list1 = new ListNode(5);

            //Console.Write(MyAtoi2("words and 987"));
            //Console.Write(MyAtoi2("-91283472332"));
            //Console.Write(MyAtoi("4193 with words"));

            var res = new int[] { 0, 2, 1, 5, 3, 4 };
           Console.Write(BuildArray(res)); 
            Console.ReadKey();
        }
        /// <summary>
        /// Runtime: 264 ms, faster than 17.69% of C# online submissions for Build Array from Permutation.
        /// Memory Usage: 45.6 MB, less than 58.16% of C# online submissions for Build Array from Permutation.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static  int[] BuildArray(int[] nums)
        {
            var len= nums.Length;
            var res=new int[len];
            for(int i = 0; i < len; i++)
            {
                res[i]=nums[nums[i]];
            }
            return res;
        }

    }

}
