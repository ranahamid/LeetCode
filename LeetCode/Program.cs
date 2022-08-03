using System.Collections.Generic;
using System.Numerics;
using System.Text;

int[][] nums = new int[][]
          {
                new int[2] {1,2}, new int[2]{2,3}, new int[2]{3,4},
                    new int[2] {4,5}, new int[2]{5,6}, new int[2]{6,7},
          };


int[][] nums2 = new int[][]
          {
                new int[3] {1,2,3},
                new int[3] {4,5,6},
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








var paths = new List<List<int>>()
            {
                 new List<int>() { 0,1,0,0,0,1 },
                 new List<int>() { 1,0,1,0,0,1},
                 new List<int>() { 0,1,0,1,1,0 },

                 new List<int>() { 0,0,1,0,1,0},
                 new List<int>() {0,0,1,1,0,1 },
                 new List<int>() { 1,1,0,0,1,0 },
            };


var resW1 = new string[] { "lo", "eo" };
var resW2 = new string[]
{
"i","love","leetcode","apples"
};

var res1 = new int[] { 10, 3, 8, 9, 4 };
var res2 = new int[] { 14, 21, 8, 35, 30, 21, 28, 19, 10, 25, 16, 23, 14, 13, 0, 3, 30, 9 };


Solution solution = new Solution();
Console.WriteLine(solution.DivisorSubstrings(430043, 2));

public class Solution
{
    //https://leetcode.com/problems/random-pick-index/
    private List<int> list;
    public Solution(int[] nums)
    {
        list = new List<int>(nums);
    }

    public int Pick(int target)
    {
        
    }
}

