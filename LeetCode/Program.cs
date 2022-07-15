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
            var res1 = new int[] { 2, 3, 2 };
            var res2 = new int[] { 1, 2, 9 };
            var res3 = new int[] { 2, 4, 9, 3 };
            Console.WriteLine(WordPattern("abba", "dog my cat dog"));

            Console.ReadKey();
        }
        //public class TreeNode
        //{
        //    public int val;
        //    public TreeNode left;
        //    public TreeNode right;
        //    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        //    {
        //        this.val = val;
        //        this.left = left;
        //        this.right = right;
        //    }
        //}

        /// <summary>
        /// https://leetcode.com/problems/word-pattern/
        /// Runtime: 117 ms, faster than 39.50% of C# online submissions for Word Pattern.
        /// Memory Usage: 36.8 MB, less than 35.74% of C# online submissions for Word Pattern.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="s"></param>
        /// <returns></returns>

        public static bool WordPattern(string pattern, string s)
        {
            var dicFirst = new Dictionary<char, string>();
            var dicSec = new Dictionary<string, char>();

            var words = s.Split(' ');
            if (words.Length != pattern.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                var currentVal = words[i];
                if (dicFirst.ContainsKey(pattern[i]))
                {
                    var dicVal = dicFirst[pattern[i]];
                    if (!currentVal.Equals(dicVal))
                    {
                        return false;
                    }
                }
                else
                {
                    dicFirst[pattern[i]] = currentVal;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                var currentVal = pattern[i];
                if (dicSec.ContainsKey(words[i]))
                {
                    var dicVal = dicSec[words[i]];
                    if (!currentVal.Equals(dicVal))
                    {
                        return false;
                    }
                }
                else
                {
                    dicSec[words[i]] = currentVal;
                }
            }

            return true;

        }










    }


}