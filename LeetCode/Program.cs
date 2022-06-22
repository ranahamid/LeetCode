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


           

            //ListNode list1 = new ListNode(5);

            //Console.Write(MyAtoi2("words and 987"));
            //Console.Write(MyAtoi2("-91283472332"));
            //Console.Write(MyAtoi("4193 with words"));

            var nums = new int [] { 0, 1, 2, 3, 4 };
            var index = new int[] { 0, 1, 2, 2, 1 };
            Console.WriteLine(CreateTargetArray(nums, index));
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
        /// <summary>
        /// Runtime: 152 ms, faster than 87.14% of C# online submissions for Create Target Array in the Given Order.
        /// Memory Usage: 42 MB, less than 12.14% of C# online submissions for Create Target Array in the Given Order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target= new List<int>();
            for(int i=0; i<nums.Length; i++)
            {
                target.Insert(index[i],nums[i]);
            }
            return target.ToArray();
        }



















    }
   

}
