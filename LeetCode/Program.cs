using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;



int[][] nums2 = new int[][]
          {
                new int[2] {0,1},
                new int[2] {1,2},
          };

int[][] nums1 = new int[29][]
{
new int[2] {22,19},new int[2] {16,17},new int[2] {10,7},new int[2] {27,16},new int[2] {9,9},new int[2] {21,4},new int[2] {24,2},new int[2] {12,11},new int[2] {2,5},new int[2] {24,12},new int[2] {25,7},new int[2] {7,13},new int[2] {14,9},new int[2] {23,15},new int[2] {18,17},new int[2] {22,16},new int[2] {4,14},new int[2] {14,17},new int[2] {25,11},new int[2] {12,16},new int[2] {29,3},new int[2] {22,11},new int[2] {29,2},new int[2] {24,2},new int[2] {24,15},new int[2] {7,14},new int[2] {7,3},new int[2] {7,14},new int[2] {1,3}
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
                 new List<int>() { 0,1,0,0,0,1 },
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


var resW1 = new string[] { "great", "acting", "skills" };
var resW2 = new string[]
{
"bar","foo","the"
};

int[][] nums = new int[][]
          {
               new int[] {0,0,0,0,0,0,0,0},
              //  new int[] {0,0,1,0,0,0,0,1,0,0,0,0,0},
              //  new int[]{0,0,0,0,0,0,0,1,1,1,0,0,0},
              //new int[]{0,1,1,0,1,0,0,0,0,0,0,0,0},
              //  new int[]{0,1,0,0,1,1,0,0,1,0,1,0,0},
              //new int[]{0,1,0,0,1,1,0,0,1,1,1,0,0},
              // new int[]{0,0,0,0,0,0,0,0,0,0,1,0,0},
              //new int[]{0,0,0,0,0,0,0,1,1,1,0,0,0},
              //new int[]{0,0,0,0,0,0,0,1,1,0,0,0,0},
          };
Solution solution = new Solution();

var res1 = new int[] { 0, 1, 2, 4, 5, 7 };
var res2 = new int[] { 10, 10, 1 };
Console.WriteLine(solution.SummaryRanges(res1));
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
public class Solution
{
    /// <summary>
    /// https://leetcode.com/problems/summary-ranges/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<string> SummaryRanges(int[] nums)
    { 

    }
}

public static class Helper
{
    private static IEnumerable<int> GetDivisors(int n)
    {
        if (n <= 0) { yield return default; }

        int iterator = (int)Math.Sqrt(n);

        for (int i = 1; i <= iterator; i++)
        {
            if (n % i == 0)
            {
                yield return i;

                if (i != n / i) { yield return n / i; }
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
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]]++;
            }
            else
            {
                map[s[i]] = 1;
            }
        }
        return map;
    }
    public static Dictionary<int, int> GetFrequencyInt(int[] s)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]]++;
            }
            else
            {
                map[s[i]] = 1;
            }
        }
        return map;
    }
    public static int GetDigitSum(int source)
    {
        var total = 0;
        while (source > 0)
        {
            var digit = source % 10;
            total += digit * digit;
            source = source / 10;
        }
        return total;
    }
    public static Stack<int> GetDigits(int source)
    {
        Stack<int> digits = new Stack<int>();
        while (source > 0)
        {
            var digit = source % 10;
            digits.Push(digit);
            source = source / 10;
        }
        return digits;
    }
}