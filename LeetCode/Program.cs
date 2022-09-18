﻿using LeetCode;
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
using System.IO;
using System.Diagnostics.Metrics;
using System;
using System.Reflection;
using LeetCode.NOT_SUBMITTED;

int[][] nums2 = new int[][]
          {
                new int[] {7,2},
                new int[] {0,10},
                new int[] {5,0},

                     new int[] {4,1},
                          new int[] {5,8},
                               new int[] {5,9},
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


var resW1 = new string[] { "oa", "oaa" };
var resW2 = new string[]
{
"abc","ab","bc","b"
};
char[][] nums = new char[][]
          {
               new char[] {'o','a','b','n'},
               new char[] {'a','h','k'},

          };
Solution solution = new Solution();

var res1 = new int[] { 1, 0, 2, 1, 3 };
var res2 = new int[] { 8, 2, 5, 8 };

Console.WriteLine(solution.SumPrefixScores(resW2)); //20


public class StockPrice
{
    PriorityQueue<(int, int), int> maxHeap = new PriorityQueue<(int, int), int>();
    PriorityQueue<(int, int), int> minHeap = new PriorityQueue<(int, int), int>();
    Dictionary<int, int> map = new Dictionary<int, int>();
    int latestTime = 0;
    public StockPrice()
    {
        latestTime = 0;
    }

    public void Update(int timestamp, int price)
    {
        latestTime = Math.Max(latestTime, timestamp);
        if (map.ContainsKey(timestamp))
            map[timestamp] = price;
        else
            map.Add(timestamp, price);

        maxHeap.Enqueue((price, timestamp), -price);
        minHeap.Enqueue((price, timestamp), price);
    }

    public int Current()
    {
        return map[latestTime];
    }

    public int Maximum()
    {
        var items = maxHeap.Peek();
        while (map[items.Item2] != items.Item1)
        {
              maxHeap.Dequeue();
            items = maxHeap.Peek();
        }
        // items = maxHeap.Peek();
        return items.Item1;
    }

    public int Minimum()
    {
        var items = minHeap.Peek();
        while (map[items.Item2] != items.Item1)
        {
            minHeap.Dequeue();
            items = minHeap.Peek();
        }
        //items = minHeap.Peek();
        return items.Item1;
    }
}
public static class Helper
{
    private static IEnumerable<int> GetDivisors(int number)
    {
        if (number <= 0) { yield return default; }
        int iterator = (int)Math.Sqrt(number);
        for (int sum = 1; sum <= iterator; sum++)
        {
            if (number % sum == 0)
            {
                yield return sum;
                if (sum != number / sum) { yield return number / sum; }
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
    public static Dictionary<char, int> GetFrequencyString(string sentence)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int sum = 0; sum < sentence.Length; sum++)
        {
            if (map.ContainsKey(sentence[sum]))
            {
                map[sentence[sum]]++;
            }
            else
            {
                map[sentence[sum]] = 1;
            }
        }
        return map;
    }
    public static Dictionary<int, int> GetFrequencyInt(int[] sentence)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int sum = 0; sum < sentence.Length; sum++)
        {
            if (map.ContainsKey(sentence[sum]))
            {
                map[sentence[sum]]++;
            }
            else
            {
                map[sentence[sum]] = 1;
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
