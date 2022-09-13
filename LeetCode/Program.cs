using LeetCode;
using LeetCode.Algo_1;
using LeetCode.HackerRank.Certificate;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;

using System.Xml.Linq;
using System.Security.Principal;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.XPath;
using System.Runtime.Intrinsics.Arm;

int[][] nums2 = new int[][]
          {
                new int[] {1,1,3 },
                new int[] {4,3,4},

                    new int[] {5,6,7},

          };

#region node

//ListNode eig = new ListNode(3);
//TreeNode sev = new TreeNode(4);
//TreeNode six = new TreeNode(3);
//TreeNode five = new TreeNode(2,null,sev);
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

var pathsMatrix = new List<List<int>>()
            {
                 new List<int>() { 1,2,2,3,5 },
                 new List<int>() { 1,0,1,0,0,1},
                 new List<int>() { 0,1,0,1,1,0 },

                 new List<int>() { 0,0,1,0,1,0},
                 new List<int>() {0,0,1,1,0,1 },
                 new List<int>() { 1,1,0,0,1,0 },
            };

var pathsAdjacency = new List<(Char, List<Char>)>()
            {
                ('A',new List<Char>() { 'B','F' }),
                ('B',new List<Char>() { 'A','C'}),
                ('C',new List<Char>() { 'B','E','D' }),

                ('D',new List<Char>() { 'C','E' }),
                ('E',new List<Char>() { 'D','C','F' }),
                ('F',new List<Char>() { 'A', 'E' }),
            };


var resW1 = new string[] { "oa", "oaa" };
var resW2 = new string[]
{
"withdraw 2 10", "transfer 5 1 20", "deposit 5 20", "transfer 3 4 15"
};
char[][] nums = new char[][]
          {
               new char[] {'o','a','b','n'},
               new char[] {'o','t','a','e'},
               new char[] {'a','h','k','r'},
               new char[] {'a','f','l','v'},
          };
Solution solution = new Solution();

var res1 = new int[] { 1, 9, 8, 7, 19 };
var res2 = new int[] { 9, 15, 7, 20, 3 };


#region Tree
TreeNode t5 = new TreeNode(1);
TreeNode t4 = new TreeNode(2);
TreeNode t3 = new TreeNode(4);
TreeNode t2 = new TreeNode(6, t4, t5);
TreeNode t1 = new TreeNode(9, t2, t3);
#endregion

Console.WriteLine(solution.LargestMerge("cabaa", "bcaaa")); //20


public class Solution
{
    
}


public static class Helper
{
    private static IEnumerable<int> GetDivisors(int number)
    {
        if (number <= 0) { yield return default; }
        int iterator = (int)Math.Sqrt(number);
        for (int index = 1; index <= iterator; index++)
        {
            if (number % index == 0)
            {
                yield return index;
                if (index != number / index) { yield return number / index; }
            }
        }

    }
    public static int[] ReverseSort(int[] nums)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));
        return nums;
    }
    public static int GCD(int a, int b)
    {
        if (b > a)
        {
            return GCD(b, a);
        }
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }
    public static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b;
    }
    public static Dictionary<char, int> GetFrequencyString(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int index = 0; index < s.Length; index++)
        {
            if (map.ContainsKey(s[index]))
            {
                map[s[index]]++;
            }
            else
            {
                map[s[index]] = 1;
            }
        }
        return map;
    }
    public static Dictionary<int, int> GetFrequencyInt(int[] s)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int index = 0; index < s.Length; index++)
        {
            if (map.ContainsKey(s[index]))
            {
                map[s[index]]++;
            }
            else
            {
                map[s[index]] = 1;
            }
        }
        return map;
    }
    public static int GetDigitSum(int source)
    {
        var sum = 0;
        while (source > 0)
        {
            var digit = source % 10;
            sum += digit * digit;
            source = source / 10;
        }
        return sum;
    }
    public static List<int> GetDigits(int source)
    {
        var digits = new List<int>();
        while (source > 0)
        {
            var digit = source % 10;
            digits.Add(digit);
            source = source / 10;
        }
        return digits;
    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
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
