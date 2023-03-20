﻿

//int intTemp = Convert.ToInt32(Console.ReadLine());

//IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
//Console.WriteLine(strList.Aggregate((s1, s2) => s1 + ", " + s2));




using LeetCode.codesignal;
using LeetCode.Premium;
using LeetCode.Z;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.XPath;

int[][] nums2 = new int[][]
          {
                new int[] {1,2},
                new int[] {3,4},
                new int[] {5,6},

                 new int[] {7,8},
                //new int[] {6,4},
                //new int[] {4,2},

                // new int[] {7,4},
                //new int[] {4,0},
                //new int[] {0,9},
                //new int[] {5,4},
                //new int[] {15,18},
                //new int[] {5,0},
                //new int[] {4,1},
                //new int[] {5,8},
                //new int[] {5,9},
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
#region Tree
TreeNode t6 = new TreeNode(1);
TreeNode t5 = new TreeNode(1);
TreeNode t4 = new TreeNode(3);
TreeNode t3 = new TreeNode(1, null, t6);
TreeNode t2 = new TreeNode(3, t4, t5);
TreeNode t1 = new TreeNode(2, t2, t3);
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


var resW1 = new string[]
{
"a","b","leetcode"
};
var resW2 = new char[]
{
't','h','e',' ','s','k','y',' ','i','s',' ','b','l','u','e'
};


var res1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var res2 = new int[] { 25, 64, 9, 4, 100 };


 
//Solution s = new Solution();

//Console.WriteLine(s.ShipWithinDays(res1, 5));

int n = 5;

int k = n;
int s = 0;
for (int i = 0; i < n; i++)
{
    k--;
    for (int j = 0; j < k; j++)
    {
        Console.Write(" ");
    }

    int m = n - k;
    for (int p = 0; p < m+s; p++)
    {
        Console.Write("*");
    }   
    s++;
    Console.WriteLine();
}


public class Solution
{
   
}


public static class Helper
{
    public static HashSet<int> GetPrimeFactors(int n)
    {
        HashSet<int> result = new HashSet<int>();
        while (n % 2 == 0)
        {
            if (!result.Contains(2))
                result.Add(2);
            n /= 2;
        }
        for (int i = 3; i <= Math.Sqrt(n); i++)
        {
            while (n % i == 0)
            {
                if (!result.Contains(i))
                    result.Add(i);
                n /= i;
            }
        }
        if (n > 2 && !result.Contains(n))
        {
            result.Add(n);
        }
        return result;
    }

    private static IEnumerable<int> GetDivisors(int number)
    {
        if (number <= 0) { yield return default; }
        int iterator = (int)Math.Sqrt(number);
        for (int answer = 1; answer <= iterator; answer++)
        {
            if (number % answer == 0)
            {
                yield return answer;
                if (answer != number / answer) { yield return number / answer; }
            }
        }

    }
    public static int[] ReverseSort(int[] nums)
    {
        Array.Sort(nums, (left, right) => right.CompareTo(left));
        return nums;
    }
    public static int GCD(int left, int right)
    {
        if (right > left)
        {
            return GCD(right, left);
        }
        if (right == 0)
        {
            return left;
        }
        return GCD(right, left % right);
    }
    public static int LCM(int left, int right)
    {
        return (left / GCD(left, right)) * right;
    }
    public static Dictionary<char, int> GetFrequencyString(string sentence)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int answer = 0; answer < sentence.Length; answer++)
        {
            if (map.ContainsKey(sentence[answer]))
            {
                map[sentence[answer]]++;
            }
            else
            {
                map[sentence[answer]] = 1;
            }
        }
        return map;
    }
    public static Dictionary<int, int> GetFrequencyInt(int[] sentence)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int answer = 0; answer < sentence.Length; answer++)
        {
            if (map.ContainsKey(sentence[answer]))
            {
                map[sentence[answer]]++;
            }
            else
            {
                map[sentence[answer]] = 1;
            }
        }
        return map;
    }
    public static int GetDigitSum(int source)
    {
        var answer = 0;
        while (source > 0)
        {
            var digit = source % 10;
            answer += digit;
            source = source / 10;
        }
        return answer;
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
public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}
