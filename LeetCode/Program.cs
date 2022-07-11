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
            var resW1 = new char[] { 'z', 'a', 'b', 'c', 'x', 'x', 'x' };
            var resW2 = new string[]
            {
            "./","wz4/","../","mj2/","../","../","ik0/","il7/"
            };
            var res1 = new int[] {1,1,1 };
            var res2 = new int[] { 1,2,9 };
            var res3 = new int[] { 6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6, 10, 8, 2, 3, 4 };
            // var res3 = new int[] {3,8,-10,23,19,-4,-14,27};
            //Solution s = new Solution();
            //var rd=s.LevelOrderPrint(res1);
            //Console.WriteLine(IsSameTree(rd,rd));

            Console.WriteLine(DistributeCandies(10,3));
            Console.ReadKey();
        }
        public static int[] DistributeCandies(int candies, int num_people)
        {
            var counter = 1;
             
            int sum = 0;
            var result = new int[num_people];
            var index = 0;
            while (candies > 0)
            {
                if (candies - sum > counter)
                {
                    sum += counter;
                    result[index] = result[index] +counter;
                }
                else
                {
                    var remaining = candies - sum;
                    result[index] = result[index] + remaining;
                    break;
                }
                counter++;
                index++;
                if (index >= num_people)
                    index = 0;
            }
            return result.ToArray();
        }
















    }


}